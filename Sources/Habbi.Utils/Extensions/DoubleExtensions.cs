namespace Habbi.Utils.Extensions
{
    /// <summary>
    ///     The class providing extension methods on <see cref="double" />s.
    /// </summary>
    public static class DoubleExtensions
    {
        /// <summary>
        ///     Returns a value indicating whether the specified number evaluates to negative or positive infinity.
        /// </summary>
        public static bool IsInfinity(this double @this) => double.IsInfinity(@this);

        /// <summary>
        ///     Returns a value that indicates whether the specified value is not a number.
        /// </summary>
        public static bool IsNaN(this double @this) => double.IsNaN(@this);

        /// <summary>
        ///     Returns a value indicating whether the specified number evaluates to positive infinity.
        /// </summary>
        public static bool IsPositiveInfinity(this double @this) => double.IsPositiveInfinity(@this);

        /// <summary>
        ///     Returns a value indicating whether the specified number evaluates to negative infinity.
        /// </summary>
        public static bool IsNegativeInfinity(this double @this) => double.IsNegativeInfinity(@this);
    }
}