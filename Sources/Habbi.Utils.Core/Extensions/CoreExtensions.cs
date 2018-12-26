using System;

#nullable enable

namespace Habbi.Utils.Core.Extensions
{
    public static class CoreExtensions
    {
        /// <summary>
        ///     Indicates wether this <see cref="object" /> is compatible with the given <see cref="Type" />.
        /// </summary>
        /// <typeparam name="T">The <see cref="Type" /> to check compatability with</typeparam>
        public static bool Is<T>(this object @this) => @this is T;

        /// <summary>
        ///     Casts this <see cref="object" /> to the given <see cref="Type" />.
        ///     Returns null of type <see cref="T" /> if the cast fails.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>The cast target <see cref="Type" /> or null if the cast fails</returns>
        public static T? As<T>(this object @this) where T : class => @this as T;

        /// <summary>
        ///     Gets nameof(this).
        /// </summary>
        /// <returns>nameof(this)</returns>
        public static string Name(this object @this) => nameof(@this);
    }
}