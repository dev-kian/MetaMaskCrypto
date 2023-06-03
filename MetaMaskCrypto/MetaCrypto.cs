using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace MetaMaskCrypto;

public class MetaCrypto
{
    /// <summary>
    /// Encrypts the payload object using the specified password.
    /// </summary>
    /// <typeparam name="T">The type of the payload object.</typeparam>
    /// <param name="password">The password used for encryption.</param>
    /// <param name="payload">The object to be encrypted.</param>
    /// <returns>The encrypted payload as a string.</returns>
    public string Encrypt<T>(string password, T payload)
    {
        Assert.NotNull(payload);

        return Encrypt(password, JsonSerializer.Serialize(payload));
    }

    /// <summary>
    /// Encrypts the payload string using the specified password.
    /// </summary>
    /// <param name="password">The password used for encryption.</param>
    /// <param name="payload">The string to be encrypted.</param>
    /// <returns>The encrypted payload as a string.</returns>
    public string Encrypt(string password, string payload)
    {
        Assert.NotNull(password);
        Assert.NotNull(payload);

        var salt = Convert.ToBase64String(AesGcm256.NewKey());
        var key = KeyFromPassword(password, salt);
        var iv = AesGcm256.NewIV();
        var encryptedText = AesGcm256.Encrypt(payload, key, iv);
        var ivText = Convert.ToBase64String(iv);
        var encryptedPayload = new
        {
            data = encryptedText,
            iv = ivText,
            salt
        };
        return JsonSerializer.Serialize(encryptedPayload);
    }

    public string Decrypt(string password, string payload)
    {
        Assert.NotNull(payload);

        var payloadObj = JsonSerializer.Deserialize<Payload>(payload);
        return DecryptWithPayload(password, payloadObj);
    }

    public string Decrypt(string password, string data, string iv, string salt)
    {
        var payload = new Payload(data, iv, salt);
        return DecryptWithPayload(password, payload);
    }

    private string DecryptWithPayload(string password, Payload payload)
    {
        Assert.NotNull(password);
        Assert.NotNull(payload.Data);
        Assert.NotNull(payload.IV);
        Assert.NotNull(payload.Salt);

        var key = KeyFromPassword(password, payload.Salt);
        var decryptedText = DecryptWithKey(key, payload);
        return decryptedText;
    }

    private string DecryptWithKey(byte[] key, Payload payload)
    {
        var vector = Convert.FromBase64String(payload.IV);

        return AesGcm256.Decrypt(payload.Data, key, vector);
    }

    private byte[] KeyFromPassword(string password, string salt)
    {
        byte[] saltBuffer = Convert.FromBase64String(salt);

        using (Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(password, saltBuffer, 10000, HashAlgorithmName.SHA256))
        {
            return deriveBytes.GetBytes(32);
        }
    }


    public string MnemonicBytesToString(byte[] mnemonic)
    {
        Assert.NotNull(mnemonic);

        return Encoding.UTF8.GetString(mnemonic);
    }

    public string MnemonicBytesToString(IEnumerable<byte> mnemonic)
    {
        Assert.NotNull(mnemonic);

        return MnemonicBytesToString(mnemonic.ToArray());
    }
}
