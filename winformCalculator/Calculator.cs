using System;
using System.Linq;
using System.Text;

namespace winformCalculator
{

    public class Calculator
    {
        public int BitCount;
        public EMode Mode;


        public Calculator(int bitCount, EMode mode)
        {
            this.BitCount = bitCount;
            this.Mode = mode;
        }

        /// <summary>
        /// 1의 보수 반환
        /// </summary>
        /// <param name="num">헤더X</param>
        /// <returns>헤더X</returns>
        public static string GetOnesComplement(string num)
        {
            char[] binaryArray = num.ToCharArray();
            for (int i = 0; i < binaryArray.Length; i++)
            {
                binaryArray[i] = (char)('1' - binaryArray[i] + '0');
            }
            return new string(binaryArray);
        }

        /// <summary>
        /// 2의 보수
        /// </summary>
        /// <param name="num">헤더X</param>
        /// <returns>헤더X</returns>
        public static string GetTwosComplement(string num)
        {
            char[] binaryArray = GetOnesComplement(num).ToCharArray();
            int carry = 1;
            for (int i = binaryArray.Length - 1; i >= 0; i--)
            {
                int temp = (binaryArray[i] - '0') ^ carry;
                carry &= binaryArray[i] - '0';
                binaryArray[i] = (char)(temp + '0');

                if (carry == 0)
                {
                    break;
                }
            }
            return new string(binaryArray);
        }

        /// <summary>
        /// 0x,decimal, 0b  ==>  0b
        /// </summary>
        /// <param name="num"></param>
        /// <returns>0b</returns>
        public static string ToBinary(string num)
        {
            StringBuilder result = new StringBuilder();
            const int TO_ALPHABET = 55;

            #region 0b일때 그대로 반환
            if (num.Contains("0b"))
            {
                return num;
            }
            #endregion

            #region Decimal 양수일 때
            if (num[0] - '0' > 0)
            {
                return result.Append(DivideByTwo(num, 1)).ToString(); // 양수
            }
            #endregion

            #region Decimal 음수일 때
            if (num[0] == '-')
            {
                num = num.Remove(0, 1);
                result.Append(DivideByTwo(num, 1));
                string twosComplete = GetTwosComplement(result.ToString());

                if (IsPowerOfTwo(result.ToString(), twosComplete)) // 음수 + 승수
                {
                    return result.Remove(0, 1).ToString();
                }
                return twosComplete;
            }
            #endregion

            #region Hex일 때
            if (num.Contains("0x"))
            {
                for (int i = 2; i < num.Length; i++)
                {
                    int temp = num[i] >= 'A' ? num[i] - TO_ALPHABET : num[i] - '0';
                    if (num[i] - '0' >= 8)
                    {
                        result.Append(DivideByTwo(temp.ToString(), 2)); // Alphabet
                    }
                    else
                    {
                        result.Append(DivideByTwo(num[i].ToString(), 1).PadLeft(4, '0')); // Number
                    }
                }
                return result.ToString();
            }
            #endregion

            return num;
        }


        /// <summary>
        /// 0x,decimal,0b => 0x 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ToHex(string num)
        {
            StringBuilder result = new StringBuilder();
            if (num.Contains("0x"))
            {
                return num.Remove(0, 2);
            }
            // decimal ==> binary
            if (num[0] - '0' > 0 || num[0] == '-')
            {
                num = ToBinary(num);
            }
            if (num.Contains("0b"))
            {
                num = num.Remove(0, 2);
            }

            // (-/+ 구분) % 4로 나머지만큼 앞에 채우기
            if (num.Length % 4 != 0)
            {
                int padding = 4 - num.Length % 4;
                string prefix = new string(num[0], padding);
                num = num.Insert(0, prefix);
            }

            // 앞에서 부터 4자리씩 쪼개기
            for (int i = 0; i < num.Length; i = i + 4)
            {

                int decimalResult = int.Parse(ConvertBinaryToDecimal(num.Substring(i, 4)));
                if (decimalResult > 9)
                {
                    result.Append((char)(decimalResult + 55));
                }
                else
                {
                    result.Append(decimalResult);
                }
            }

            return result.ToString();
        }

        /// <summary>
        /// 0x,0b,decimal ==> decimal 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ToDecimal(string num)
        {
            #region decimal 
            if (num[0] - '0' > 0 || num[0] == '-')
            {
                return num;
            }
            #endregion

            StringBuilder numSb = new StringBuilder();
            bool bNegative = false;
            string result;
            if (num.Contains("0x"))
            {
                num = ToBinary(num);
            }
            else
            {
                num = num.Remove(0, 2);
            }

            if (num[0] == '1')
            {
                numSb.Append(GetTwosComplement(num));
                bNegative = true;
            }
            else
            {
                numSb.Append(num);
            }

            result = ConvertBinaryToDecimal(numSb.ToString());

            if (bNegative)
            {
                result = result.Insert(0, "-");
            }
            return result;
        }

        /// <summary>
        /// 더하기 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="bOverflow"></param>
        /// <returns></returns>
        public string Add(string num1, string num2, out bool bOverflow)
        {
            bOverflow = false;
            bool bNegative1;
            bool bNegative2;
            bool bDecimal1;
            bool bDecimal2;

            if (num1 == null || num2 == null)
            {
                return null;
            }
            #region 2진수 변환 ToBinary(0x...,0b...) 호출 & return 0b... 
            try
            {
                bNegative1 = num1[0] == '-' ? true : false;
                bNegative2 = num2[0] == '-' ? true : false;
                bDecimal1 = RegexString.IS_DECIMAL.IsMatch(num1);
                bDecimal2 = RegexString.IS_DECIMAL.IsMatch(num2);
                num1 = ToBinary(num1).Replace("0b", "");
                num2 = ToBinary(num2).Replace("0b", "");
            }
            catch (Exception)
            {
                return null;
            }
            #endregion

            #region BitCount 보다 긴 경우 null
            if (num1.Length > BitCount || num2.Length > BitCount)
            {
                return null;
            }
            #endregion

            #region 127보다 크거나 -128보다 작은 경우 null ==> hex일떄는 해당 안됨.
            // 음수인데 0으로 시작
            if (bNegative1 && num1[0] == '0' && bDecimal1 || bNegative2 && num2[0] == '0' && bDecimal2)
            {
                return null;
            }
            // 양수인데 1로
            if (!bNegative1 && num1[0] == '1' && bDecimal1 || !bNegative2 && num2[0] == '1' && bDecimal2)
            {
                return null;
            }
            #endregion

            #region 자릿수 맞추기
            if (num1.Length != BitCount)
            {
                num1 = num1.PadLeft(BitCount, num1[0]);
            }
            if (num2.Length != BitCount)
            {
                num2 = num2.PadLeft(BitCount, num2[0]);
            }
            #endregion

            #region 두 수 더하기 AddBinaryNummbers() 호출
            string result = AddBinaryNumbers(num1, num2);
            #endregion

            #region bOverflow 체크
            // 양수 + 양수 ==> 결과 음수일때 overflow
            if (num1[0] == '0' && num2[0] == '0' && result[0] == '1')
            {
                bOverflow = true;
            }
            // 음수 + 음수 ==> 결과 양수일떄 underflow
            else if (num1[0] == '1' && num2[0] == '1' && result[0] == '0')
            {
                bOverflow = true;
            }
            #endregion

            #region Decimal Mode일 경우 Decimal로 변환
            if (Mode == EMode.DECIMAL)
            {
                if (result[0] == '1')
                {
                    string negativeDecimal = ToDecimal(result.Insert(0, "0b"));
                    if (negativeDecimal.Contains("-"))
                    {
                        return negativeDecimal;
                    }
                    return ToDecimal(result.Insert(0, "0b"));
                }
                return ToDecimal(result.Insert(0, "0b"));
            }
            #endregion

            return result.Insert(0, "0b");
        }

        /// <summary>
        /// 두 이진수 더하기
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>1001xxxxxx</returns>
        public string AddBinaryNumbers(string num1, string num2)
        {
            StringBuilder result = new StringBuilder();
            int tempResult = 0;
            int remainer = 0;

            for (int i = BitCount - 1; i >= 0; i--)
            {
                int num1ToInt = num1[i] - '0';
                int num2ToInt = num2[i] - '0';

                tempResult = num1ToInt ^ num2ToInt ^ remainer;
                remainer = (remainer & num1ToInt) | (remainer & num2ToInt) | (num1ToInt & num2ToInt);
                result.Append(tempResult);

            }

            #region BitCount에 맞게 맞추기
            if (result.Length > BitCount)
            {
                return new string(result.ToString().Substring(0, BitCount).Reverse().ToArray());
            }
            #endregion
            return new string(result.ToString().Reverse().ToArray());
        }

        /// <summary>
        /// 빼기 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public string Subtract(string num1, string num2, out bool bOverflow)
        {
            bOverflow = false;
            bool bNegative1;
            bool bNegative2;
            bool bDecimal1;
            bool bDecimal2;

            if (num1 == null || num2 == null)
            {
                return null;
            }
            #region 2진수 변환 ToBinary(0x...,0b...) 호출 & return 0b... 
            try
            {
                bNegative1 = num1[0] == '-' ? true : false;
                bNegative2 = num2[0] == '-' ? true : false;
                bDecimal1 = RegexString.IS_DECIMAL.IsMatch(num1);
                bDecimal2 = RegexString.IS_DECIMAL.IsMatch(num2);
                num1 = ToBinary(num1).Replace("0b", "");
                num2 = ToBinary(num2).Replace("0b", "");
            }
            catch (Exception)
            {
                return null;
            }
            #endregion

            #region BitCount 보다 긴 경우 null
            if (num1.Length > BitCount || num2.Length > BitCount)
            {
                return null;
            }
            #endregion

            #region 127보다 크거나 -128보다 작은 경우 null ==> hex일떄는 해당 안됨.
            // 음수인데 0으로 시작
            if (bNegative1 && num1[0] == '0' && bDecimal1 || bNegative2 && num2[0] == '0' && bDecimal2)
            {
                return null;
            }
            // 양수인데 1로
            if (!bNegative1 && num1[0] == '1' && bDecimal1 || !bNegative2 && num2[0] == '1' && bDecimal2)
            {
                return null;
            }
            #endregion

            #region 자릿수 맞추기
            if (num1.Length != BitCount)
            {
                num1 = num1.PadLeft(BitCount, num1[0]);
            }
            if (num2.Length != BitCount)
            {
                num2 = num2.PadLeft(BitCount, num2[0]);
            }
            #endregion

            #region num2를 2의 보수로 변환
            num2 = GetTwosComplement(num2).Replace("0b", ""); // 0bxxx으로 넘기고 0101xxx로반환
            #endregion

            #region 두 수 더하기 AddBinaryNummbers() 호출
            string result = AddBinaryNumbers(num1, num2);
            #endregion

            #region bOverflow 체크
            // 양수 + 양수 ==> 결과 음수일때 overflow
            if (num1[0] == '0' && num2[0] == '0' && result[0] == '1')
            {
                bOverflow = true;
            }
            // 음수 + 음수 ==> 결과 양수일떄 underflow
            else if (num1[0] == '1' && num2[0] == '1' && result[0] == '0')
            {
                bOverflow = true;
            }
            #endregion

            #region Decimal Mode일 경우 Decimal로 변환
            if (Mode == EMode.DECIMAL)
            {
                if (result[0] == '1')
                {
                    result = GetTwosComplement(result);
                    return ToDecimal(result).Insert(0, "-");
                }
                return ToDecimal(result);
            }
            #endregion

            return result.Insert(0, "0b");
        }


        /// <summary>
        /// binary 구하기 => 2로 나누기
        /// </summary>
        /// <param name="num"></param>
        /// <param name="endConditionQuotient">{1:양수, 0x_Num, 2:음수+2의승수, 0x_Alphabet}</param>
        /// <returns>binary</returns>
        private static string DivideByTwo(string num, int endConditionQuotient)
        {
            if (num.Length == 1 && num[0] == '0')
            {
                return num;
            }

            StringBuilder result = new StringBuilder();
            StringBuilder numStr = new StringBuilder(num);

            while (true)
            {
                int carry = 0; // 나머지
                int digit = 0; // 한자리
                int quotient = 0; // 몫

                int numLength = numStr.Length;
                for (int i = 0; i < numLength; i++)
                {
                    digit = numStr[i] - '0';
                    quotient = (carry * 10 + digit) / 2;
                    carry = digit % 2;

                    numStr.Remove(i, 1).Insert(i, quotient);
                }
                result.Insert(0, carry);

                if (numStr.Length == 1 && numStr[0] - '0' < endConditionQuotient)
                {
                    result.Insert(0, quotient);
                    break;
                }

                if (numStr[0] == '0')
                {
                    numStr.Remove(0, 1);

                }
            }

            return result.ToString();
        }

        /// <summary>
        /// 2의 승수 확인
        /// </summary>
        /// <param name="num"></param>
        /// <returns>bool</returns>
        private static bool IsPowerOfTwo(string num, string twosComplete)
        {
            num = num.Remove(num.Length - 1, 1);
            num = num.Insert(0, "0");

            for (int i = 0; i < num.Length; i++)
            {
                if ((num[i] - '0' & twosComplete[i] - '0') != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static string ConvertBinaryToDecimal(string num)
        {
            if (num.Equals("0000"))
            {
                return "0";
            }
            StringBuilder result = new StringBuilder();
            StringBuilder currPower = new StringBuilder();

            for (int i = num.Length - 1; i >= 0; i--)
            {
                StringBuilder temp = new StringBuilder();
                int carry = 0;
                for (int j = currPower.Length - 1; j >= 0; j--)
                {
                    int partialProduct = (currPower[j] - '0') * 2 + carry;
                    int digit = partialProduct % 10;
                    carry = partialProduct / 10;

                    temp.Insert(0, digit);
                }
                if (carry == 1) { temp.Insert(0, carry); }

                if (currPower.Length == 0)
                {
                    currPower.Append(1);
                }
                else
                {
                    currPower = temp;
                }

                // sum
                if (num[i] == '1')
                {
                    StringBuilder tempForSum = new StringBuilder();
                    int carryForSum = 0;
                    int partialSum = 0;
                    int j = result.Length;

                    for (int k = currPower.Length - 1; k >= 0; k--)
                    {
                        if (j != 0)
                        {
                            partialSum = currPower[k] - '0' + (result[--j] - '0') + carryForSum;
                        }
                        else
                        {
                            partialSum = currPower[k] - '0' + carryForSum;
                        }
                        carryForSum = partialSum / 10;
                        tempForSum.Insert(0, partialSum % 10);
                    }
                    if (carryForSum == 1) { tempForSum.Insert(0, carryForSum); }

                    result = tempForSum;

                }
            }
            return result.ToString();
        }



    }
}
