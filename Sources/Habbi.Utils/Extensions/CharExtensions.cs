namespace Habbi.Utils.Extensions
{
    /// <summary>
    ///     The class providing extension methods on <see cref="char" />s.
    /// </summary>
    public static class CharExtensions
    {
        /// <summary>
        ///     Indicates whether this Unicode character is categorized as a control character.
        /// </summary>
        public static bool IsControl(this char c) => char.IsControl(c);

        /// <summary>
        ///     Indicates whether this Unicode character is categorized as a decimal digit.
        /// </summary>
        public static bool IsDigit(this char c) => char.IsDigit(c);

        /// <summary>
        ///     Indicates whether this Char object is a high surrogate.
        /// </summary>
        public static bool IsHighSurrogate(this char c) => char.IsHighSurrogate(c);

        /// <summary>
        ///     Indicates whether this Unicode character is categorized as a Unicode letter.
        /// </summary>
        public static bool IsLetter(this char c) => char.IsLetter(c);

        /// <summary>
        ///     Indicates whether this Unicode character is categorized as a letter or a decimal digit.
        /// </summary>
        public static bool IsLetterOrDigit(this char c) => char.IsLetterOrDigit(c);

        /// <summary>
        ///     Indicates whether this Unicode character is categorized as a lowercase letter.
        /// </summary>
        public static bool IsLower(this char c) => char.IsLower(c);

        /// <summary>
        ///     Indicates whether this Char object is a low surrogate.
        /// </summary>
        public static bool IsLowSurrogate(this char c) => char.IsLowSurrogate(c);

        /// <summary>
        ///     Indicates whether this Unicode character is categorized as a number.
        /// </summary>
        public static bool IsNumber(this char c) => char.IsNumber(c);

        /// <summary>
        ///     Indicates whether this Unicode character is categorized as a punctuation mark.
        /// </summary>
        public static bool IsPunctuation(this char c) => char.IsPunctuation(c);

        /// <summary>
        ///     Indicates whether this Unicode character is categorized as a separator character.
        /// </summary>
        public static bool IsSeparator(this char c) => char.IsSeparator(c);

        /// <summary>
        ///     Indicates whether this character has a surrogate code unit.
        /// </summary>
        public static bool IsSurrogate(this char c) => char.IsSurrogate(c);

        /// <summary>
        ///     Indicates whether this Unicode character is categorized as a symbol character.
        /// </summary>
        public static bool IsSymbol(this char c) => char.IsSymbol(c);

        /// <summary>
        ///     Indicates whether this Unicode character is categorized as an uppercase letter.
        /// </summary>
        public static bool IsUpper(this char c) => char.IsUpper(c);

        /// <summary>
        ///     Indicates whether this Unicode character is categorized as white space.
        /// </summary>
        public static bool IsWhiteSpace(this char c) => char.IsWhiteSpace(c);

        /// <summary>
        ///     Converts the value of a Unicode character to its lowercase equivalent.
        /// </summary>
        public static char ToLower(this char c) => char.ToLower(c);

        /// <summary>
        ///     Converts the value of a Unicode character to its uppercase equivalent.
        /// </summary>
        public static char ToUpper(this char c) => char.ToUpper(c);
    }
}