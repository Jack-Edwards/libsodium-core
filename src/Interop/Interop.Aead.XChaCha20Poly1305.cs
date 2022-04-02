using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Libsodium
    {
        internal const int crypto_aead_xchacha20poly1305_ietf_ABYTES = 16;
        internal const int crypto_aead_xchacha20poly1305_ietf_KEYBYTES = 32;
        internal const int crypto_aead_xchacha20poly1305_ietf_NPUBBYTES = 24;

        [DllImport(Libraries.Libsodium, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int crypto_aead_xchacha20poly1305_ietf_decrypt(
            byte[] m,
            ref ulong mlen_p,
            byte[] nsec,
            byte[] c,
            ulong clen,
            byte[] ad,
            ulong adlen,
            byte[] npub,
            byte[] k);

        [DllImport(Libraries.Libsodium, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int crypto_aead_xchacha20poly1305_ietf_encrypt(
            byte[] c,
            ref ulong clen_p,
            byte[] m,
            ulong mlen,
            byte[] ad,
            ulong adlen,
            byte[] nsec,
            byte[] npub,
            byte[] k);
    }
}
