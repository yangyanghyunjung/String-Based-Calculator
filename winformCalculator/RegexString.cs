using System.Text.RegularExpressions;

namespace winformCalculator
{
    public static class RegexString
    {
        public static readonly Regex IS_BINARY = new Regex("^0b[01]+$");
        public static readonly Regex IS_HEX = new Regex("^0x[0-9A-F]+$");
        public static readonly Regex IS_DECIMAL = new Regex("^(-?[1-9][0-9]*|0)$");
    }
}
