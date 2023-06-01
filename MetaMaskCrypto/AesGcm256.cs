using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System.Text;

namespace MetaMaskCrypto;

internal abstract class AesGcm256
{
    private static readonly SecureRandom Random = new SecureRandom();

    private const int NonceBitSize = 128;
    private const int MacBitSize = 128;
    private const int KeyBitSize = 256;

    public static byte[] NewKey()
    {
        var key = new byte[KeyBitSize / 8];
        Random.NextBytes(key);
        return key;
    }

    public static byte[] NewIV()
    {
        var iv = new byte[NonceBitSize / 8];
        Random.NextBytes(iv);
        return iv;
    }

    public static string Encrypt(string plainText, byte[] key, byte[] iv)
    {
        byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

        GcmBlockCipher cipher = new GcmBlockCipher(new AesEngine());
        AeadParameters parameters = new AeadParameters(new KeyParameter(key), MacBitSize, iv, null);
        
        cipher.Init(true, parameters);
        byte[] encryptedBytes = new byte[cipher.GetOutputSize(plainBytes.Length)];
        int encryptedLength = cipher.ProcessBytes(plainBytes, 0, plainBytes.Length, encryptedBytes, 0);
        cipher.DoFinal(encryptedBytes, encryptedLength);

        string encryptedText = Convert.ToBase64String(encryptedBytes, Base64FormattingOptions.None);
        return encryptedText;
    }

    public static string Decrypt(string encryptedText, byte[] key, byte[] iv)
    {
        byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

        GcmBlockCipher cipher = new GcmBlockCipher(new AesEngine());
        AeadParameters parameters = new AeadParameters(new KeyParameter(key), MacBitSize, iv, null);

        cipher.Init(false, parameters);
        byte[] plainBytes = new byte[cipher.GetOutputSize(encryptedBytes.Length)];
        int decryptedLength = cipher.ProcessBytes(encryptedBytes, 0, encryptedBytes.Length, plainBytes, 0);
        cipher.DoFinal(plainBytes, decryptedLength);

        string plainText = Encoding.UTF8.GetString(plainBytes).TrimEnd("\r\n\0".ToCharArray());
        return plainText;
    }
}
