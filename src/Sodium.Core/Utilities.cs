using static Interop.Libsodium;

namespace Sodium
{
    /// <summary>Various utility methods.</summary>
    public static partial class Utilities
    {
        /// <summary>
        /// Takes a unsigned number, and increments it.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <returns>The incremented value.</returns>
        public static byte[] Increment(byte[] value)
        {
            var buffer = value;
            sodium_increment(buffer, (nuint)buffer.Length);

            return buffer;
        }

        /// <summary>
        /// Compares two values in constant time.
        /// </summary>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        /// <returns><c>true</c> if the values are equal, otherwise <c>false</c></returns>
        public static bool Compare(byte[] a, byte[] b)
        {
            var ret = sodium_compare(a, b, (nuint)a.Length);

            return ret == 0;
        }
    }
}
