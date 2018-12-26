using System;

namespace Habbi.Utils.Core.Extensions
{
    /// <summary>
    ///     The class providing extension methods on <see cref="decimal" />s.
    /// </summary>
    public static class DecimalExtensions
    {
        /// <summary>
        ///     Adds a specified <see cref="decimal" /> to this decimal.
        /// </summary>
        /// <param name="add">The decimal to add</param>
        /// <returns>This decimal plus the specified <see cref="decimal" /></returns>
        /// <exception cref="OverflowException"></exception>
        public static decimal Add(this decimal d, decimal add) => decimal.Add(d, add);

        /// <summary>
        ///     Divides this decimal with a specified <see cref="decimal" />.
        /// </summary>
        /// <param name="divisor">The decimal to divide with</param>
        /// <returns>This decimal divided by the specified <see cref="decimal" /></returns>
        /// <exception cref="DivideByZeroException"></exception>
        /// <exception cref="OverflowException"></exception>
        public static decimal DivideWith(this decimal d, decimal divisor) => decimal.Divide(d, divisor);

        /// <summary>
        ///     Multiplies this decimal with a specified <see cref="decimal" />.
        /// </summary>
        /// <param name="factor">The decimal to multiply with</param>
        /// <returns>This decimal multiplied with the specified <see cref="decimal" /></returns>
        /// <exception cref="OverflowException"></exception>
        public static decimal MultiplyWith(this decimal d, decimal factor) => decimal.Multiply(d, factor);

        /// <summary>
        ///     Negates this decimal.
        /// </summary>
        /// <returns>This decimal times -1</returns>
        public static decimal Negate(this decimal d) => decimal.Negate(d);

        /// <summary>
        ///     Subtracts a specified <see cref="decimal" /> from this decimal.
        /// </summary>
        /// <param name="subtrahend">The decimal to subtract</param>
        /// <returns>This decimal minus the specified <see cref="decimal" /></returns>
        public static decimal Subtract(this decimal d, decimal subtrahend) => decimal.Subtract(d, subtrahend);

        /// <summary>
        ///     Discards any fractional digits from this decimal.
        /// </summary>
        /// <returns>This decimal without fractional digits</returns>
        public static decimal Truncate(this decimal d) => decimal.Truncate(d);
    }
}