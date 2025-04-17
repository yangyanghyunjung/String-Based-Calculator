# 🧮 String-Based BigNumber Calculator

**C# / .NET / WinForms 기반 초대형 진법 변환 계산기**

## 🧠 진법 변환 깊이 파보기

**WinForms 기반 C# 계산기**로, `Convert.ToString(value, 2)` 등의 **내장 메서드를 사용하지 않고**  
직접 구현한 알고리즘으로 **2진수, 10진수, 16진수 간 진법 변환을 수행**합니다.  
진법 변환을 직접 구현하며, 컴퓨터 내부에서 숫자가 어떻게 어떻게 표현하고 처리하는지를 체계적으로 배우기 위해 제작하였습니다.

## 🚀 사용 기술

- **언어**: `C#`
- **프레임워크**: `.NET`
- **UI**: `WinForms (Windows Forms)`
- **IDE**: `Visual Studio`


## 📚 목표

- **진법 변환** 로직 구현
  - `Convert.ToString(value, 2)` 사용 ❌
- 각 자리의 이진수 가중치 (2⁰, 2¹, 2², ...) 직접 구현
  - `Math.pow()` 사용 ❌
- **2의 보수** 방식의 음수 표현 구조 이해
- `int(32bit)` 표현 범위를 넘는 수 계산, 변환
  - `double`, `long` 사용 ❌


## 🧮 진법별 표현 방식

| 진법     | 한 자리에서 표현 가능한 범위 | 예시         |
|----------|-------------------------------|--------------|
| 2진수    | `0` ~ `1`                     | `0b1010`     |
| 10진수   | `0` ~ `9`                     | `42`         |
| 16진수   | `0` ~ `15` (`0`~`F`)          | `0x2A`       |

> 💡 16진수 한 자리는 **정확히 4자리 2진수와 대응** 
> 🧠**why?**: 16진수의 최대값 `15`는 2진수로 `1111`이며, 이는 4비트로 표현 됨.


## 🛠 주요 기능

- 🔁 진법 변환 기능:
  - 2진수 → 10진수 / 16진수
  - 10진수 → 2진수 / 16진수
  - 16진수 → 2진수 / 10진수
- ➕ 기본 연산 (문자열 기반): 덧셈, 뺄셈
- 🧠 **문자열 연산 기반**이기 때문에 오버플로우 / 언더플로우 걱정 없이 **초대형 숫자도 처리 가능**

---

## 🧩 주요 로직

```csharp
// 두 이진수를 한 자리씩 더하기(생략)
private string AddBinaryNumbers(string num1, string num2)
{
  for (int i = BitCount - 1; i >= 0; i--)
  {
    int num1ToInt = num1[i] - '0';
    int num2ToInt = num2[i] - '0';

    tempResult = num1ToInt ^ num2ToInt ^ remainer;
    remainer = (remainer & num1ToInt) | (remainer & num2ToInt) | (num1ToInt & num2ToInt);
    result.Append(tempResult);
  }
}
```
```csharp
// 1의 보수 구하기(생략)
private string GetOnesComplement(string num)
{
    char[] binaryArray = num.ToCharArray();
    for (int i = 0; i < binaryArray.Length; i++)
    {
        binaryArray[i] = (char)('1' - binaryArray[i] + '0');
    }
    return new string(binaryArray);
}
```
```csharp
// 2의 거듭제곱 구하기 (한 자리씩 곱셈)
private string ConvertBinaryToDecimal(string num)
{
   for (int j = currPower.Length - 1; j >= 0; j--)
  {
    int partialProduct = (currPower[j] - '0') * 2 + carry;
    int digit = partialProduct % 10;
    carry = partialProduct / 10;

    temp.Insert(0, digit);
  }
  if (carry == 1) { temp.Insert(0, carry); }
}
```

## 📘 사용법

### 🧾 입력 규칙

- 🔢 **Binary (2진수)** 입력 시: `0b` 접두사 붙이기  
  예: `0b1010`, `0b111`

- 🔢 **Hexadecimal (16진수)** 입력 시: `0x` 접두사 붙이기  
  예: `0xA`, `0x0F`, `0x1C`

- 🔢 **Decimal (10진수)** 입력 시: 그냥 숫자 입력  
  예: `42`, `15`, `-7`

### 🧮 계산 결과 모드 설정

- 계산 결과는 원하는 출력 형식으로 선택 가능:
  - ✅ **Binary 모드** 
  - ✅ **Decimal 모드** 

### 📁 주요 로직 파일 위치

├ **winformCalculator**  
├── 📄 Calculator.cs               // 핵심 로직 (진법 변환, 계산 등)   
├── 📄 MainForm.cs                 // 메인 폼 (UI 이벤트 핸들)   
│   ├── 📄 MainForm.Designer.cs    // 메인 폼 UI 구성   
│   └── 📄 MainForm.resx           // 리소스 파일   

### ⚠️ 진법 변환 주의사항

진법에 따라 **앞자리 0의 유무**에 따라 다른 값이 될 수 있음.

- 예:  
  `0xA` → `1010` → (부호 있는 수로 해석) `-6`  
  `0x0A` → `01010` → `10` (양수)


## 📷 

- **Base Conversion**
![Image](https://github.com/user-attachments/assets/56d9acf9-1dbe-4a12-b586-671883a09af9)   

- **No Under Flow**
![Image](https://github.com/user-attachments/assets/aea997b1-347d-4937-ad13-1ee95e0ea655)   

- **No Over Flow**
![Image](https://github.com/user-attachments/assets/20e843a7-1dbe-49c7-a35e-0da2b86c84a2)




