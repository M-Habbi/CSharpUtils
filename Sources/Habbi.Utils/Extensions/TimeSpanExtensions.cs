using System;

namespace Habbi.Utils.Extensions
{
    /// <summary>
    ///     The class providing extension methods on <see cref="TimeSpan" />s.
    /// </summary>
    public static class TimeSpanExtensions
    {
        /// <summary>
        ///     Compares two <see cref="TimeSpan" /> values and returns an integer that indicates whether this value is shorter
        ///     than, equal to, or longer than the specified value.
        /// </summary>
        /// <param name="compare">The <see cref="TimeSpan" /> to compare to.</param>
        /// <returns>
        ///     -1: this is shorter than the specified value. 0: this is equal to the specified value. 1: this is longer than
        ///     the specified value.
        /// </returns>
        public static int CompareTo(this TimeSpan @this, TimeSpan compare) => TimeSpan.Compare(@this, compare);

        /// <summary>
        ///     Returns a value that indicates whether this instance of <see cref="TimeSpan" /> is equal to the specified value.
        /// </summary>
        /// <param name="compare">The <see cref="TimeSpan" /> to compare to.</param>
        public static bool Equals(this TimeSpan @this, TimeSpan compare) => TimeSpan.Equals(@this, compare);
    }
}