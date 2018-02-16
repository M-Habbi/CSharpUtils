using System;

#pragma warning disable 1573

namespace Habbi.Utils.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        ///     Compares the value of this instance to a specified <see cref="DateTime" /> value and returns an integer that
        ///     indicates whether this instance is earlier than, the same as, or later than the specified <see cref="DateTime" />
        ///     value.
        /// </summary>
        /// <param name="comparer">The <see cref="DateTime" /> to be compared with.</param>
        /// <returns>
        ///     A signed number indicating the relative values of this instance and the value parameter. (Less than zero: This
        ///     instance is earlier than value. Zero: This instance is the same as value. Greater than zero: This instance is later
        ///     than value.)
        /// </returns>
        public static int CompareTo(this DateTime @this, DateTime comparer) => DateTime.Compare(@this, comparer);

        /// <summary>
        ///     Returns an indication whether the year of this <see cref="DateTime" /> is a leap year.
        /// </summary>
        public static bool IsLeapYear(this DateTime @this) => DateTime.IsLeapYear(@this.Year);

        /// <summary>
        ///     Gets the number of days in the month and year of this <see cref="DateTime" />.
        /// </summary>
        /// <returns>The number of days in this month and year.</returns>
        public static int DaysInMonth(this DateTime @this) => DateTime.DaysInMonth(@this.Year, @this.Month);
    }
}