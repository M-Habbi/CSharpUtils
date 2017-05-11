namespace Habbi.Utils
{
    public static class CharExtensions
    {
        public static bool IsControl(this char c) => char.IsControl(c);
        public static bool IsDigit(this char c) => char.IsDigit(c);
        public static bool IsHighSurrogate(this char c) => char.IsHighSurrogate(c);
        public static bool IsLetter(this char c) => char.IsLetter(c);
        public static bool IsLetterOrDigit(this char c) => char.IsLetterOrDigit(c);
        public static bool IsLower(this char c) => char.IsLower(c);
        public static bool IsLowSurrogate(this char c) => char.IsLowSurrogate(c);
        public static bool IsNumber(this char c) => char.IsNumber(c);
        public static bool IsPunctuation(this char c) => char.IsPunctuation(c);
        public static bool IsSeparator(this char c) => char.IsSeparator(c);
        public static bool IsSurrogate(this char c) => char.IsSurrogate(c);
        public static bool IsSymbol(this char c) => char.IsSymbol(c);
        public static bool IsUpper(this char c) => char.IsUpper(c);
        public static bool IsWhiteSpace(this char c) => char.IsWhiteSpace(c);
        public static char ToLower(this char c) => char.ToLower(c);
        public static char ToUpper(this char c) => char.ToUpper(c);
    }
}