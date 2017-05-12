using System;
#pragma warning disable 1573

namespace Habbi.Utils
{
    public static class StringExtensions
    {
        /// <summary>
        ///     Creates a new instance of <see cref="string" /> with the same values as this string.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public static string Copy(this string s) => string.Copy(s);

        /// <summary>
        ///     Indicates whether the character at the specified position in this string is categorized as a control character.
        /// </summary>
        /// <param name="index">Index in this string</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsControl(this string s, int index) => char.IsControl(s, index);

        /// <summary>
        ///     Indicates whether the character at the specified position in a specified string is categorized as a decimal digit.
        /// </summary>
        /// <param name="index">Index in this string</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsDigit(this string s, int index) => char.IsDigit(s, index);

        /// <summary>
        ///     Indicates whether the Char object at the specified position in a string is a high surrogate.
        /// </summary>
        /// <param name="index">Index in this string</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsHighSurrogate(this string s, int index) => char.IsHighSurrogate(s, index);

        /// <summary>
        ///     Indicates whether the character at the specified position in a specified string is categorized as a Unicode letter.
        /// </summary>
        /// <param name="index">Index in this string</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsLetter(this string s, int index) => char.IsLetter(s, index);

        /// <summary>
        ///     Indicates whether the character at the specified position in a specified string is categorized as a letter or a
        ///     decimal digit.
        /// </summary>
        /// <param name="index">Index in this string</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsLetterOrDigit(this string s, int index) => char.IsLetterOrDigit(s, index);

        /// <summary>
        ///     Indicates whether the character at the specified position in a specified string is categorized as a lowercase
        ///     letter.
        /// </summary>
        /// <param name="index">Index in this string</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsLower(this string s, int index) => char.IsLower(s, index);

        /// <summary>
        ///     Indicates whether the Char object at the specified position in a string is a low surrogate.
        /// </summary>
        /// <param name="index">Index in this string</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsLowSurrogate(this string s, int index) => char.IsLowSurrogate(s, index);

        /// <summary>
        ///     Indicates whether this string is null or a <see cref="string" />.Empty string.
        /// </summary>
        public static bool IsNullOrEmpty(this string s) => string.IsNullOrEmpty(s);

        /// <summary>
        ///     Indicates whether this string is null, emtpy, or consists only of white-space characters.
        /// </summary>
        public static bool IsNullOrWhiteSpace(this string s) => string.IsNullOrWhiteSpace(s);

        /// <summary>
        ///     Indicates whether the character at the specified position in a specified string is categorized as a number.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsNumber(this string s, int index) => char.IsNumber(s, index);

        /// <summary>
        ///     Indicates whether the character at the specified position in a specified string is categorized as a punctuation
        ///     mark.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsPunctuation(this string s, int index) => char.IsPunctuation(s, index);

        /// <summary>
        ///     Indicates whether the character at the specified position in a specified string is categorized as a separator
        ///     character.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsSeparator(this string s, int index) => char.IsSeparator(s, index);

        /// <summary>
        ///     Indicates whether the character at the specified position in a specified string has a surrogate code unit.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsSurrogate(this string s, int index) => char.IsSurrogate(s, index);

        /// <summary>
        ///     Indicates whether the character at the specified position in a specified string is categorized as a symbol
        ///     character.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsSymbol(this string s, int index) => char.IsSymbol(s, index);

        /// <summary>
        ///     Indicates whether the character at the specified position in a specified string is categorized as an uppercase
        ///     letter.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsUpper(this string s, int index) => char.IsUpper(s, index);

        /// <summary>
        ///     Indicates whether the character at the specified position in a specified string is categorized as white space.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsWhiteSpace(this string s, int index) => char.IsWhiteSpace(s, index);
    }
}