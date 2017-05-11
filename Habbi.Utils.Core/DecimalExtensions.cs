namespace Habbi.Utils.Core
{
    public static class DecimalExtensions
    {
        public static decimal Add(this decimal d, decimal add) => decimal.Add(d, add);
        public static decimal DivideWith(this decimal d, decimal divisor) => decimal.Add(d, divisor);
        public static decimal MultiplyWith(this decimal d, decimal factor) => decimal.Add(d, factor);
        public static decimal Negate(this decimal d) => decimal.Negate(d);
        public static decimal Subtract(this decimal d, decimal subtrahend) => decimal.Subtract(d, subtrahend);
        public static decimal Truncate(this decimal d) => decimal.Truncate(d);
    }
}