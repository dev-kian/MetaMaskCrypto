using MetaMaskCrypto;
using Xunit.Abstractions;

namespace Test;

public class MetaCryptoTests
{
    private readonly ITestOutputHelper _output;
    private readonly MetaCrypto _crypto;

    public MetaCryptoTests(ITestOutputHelper output)
    {
        _output = output;
        _crypto = new MetaCrypto();
    }

    [Theory]
    [InlineData("Admin231@", "[{\"type\":\"HD Key Tree\",\"data\":{\"mnemonic\":[110,97,105,118,101,32,118,101,110,100,111,114,32,98,111,110,117,115,32,114,101,102,108,101,99,116,32,100,111,99,117,109,101,110,116,32,114,101,99,121,99,108,101,32,99,97,116,101,103,111,114,121,32,100,101,99,108,105,110,101,32,103,97,114,98,97,103,101,32,100,101,99,111,114,97,116,101,32,100,97,121,32,97,119,102,117,108],\"numberOfAccounts\":3,\"hdPath\":\"m/44'/60'/0'/0\"}},{\"type\":\"Ledger Hardware\",\"data\":{\"hdPath\":\"m/44'/60'/0'\",\"accounts\":[],\"accountDetails\":{},\"bridgeUrl\":\"https://metamask.github.io/eth-ledger-bridge-keyring\",\"implementFullBIP44\":false}}]")]
    public void Encrypt_WithValidPasswordAndPayload_ReturnsEncryptedText(string password, string payload)
    {
        // Act
        var encryptedText = _crypto.Encrypt(password, payload);

        // Assert
        Assert.NotNull(encryptedText);
        Assert.NotEmpty(encryptedText);
        Assert.NotEqual(payload, encryptedText);

        _output.WriteLine(encryptedText);
    }

    [Theory]
    [InlineData("Admin231@", "{\"data\":\"0UTpH53VzgKxrOF3aFBYyByZNC6Xy7Xp8A3pWd04GnW7ei8s6bVgkUNNSwnTei96pCxGd3CH26CBnqmuXj4QLd/rEyUocpplR6sEXYCpt+QvS951e8QwsgzWNnEBHJjw0LdiFathFNOBt8pBhBTX72YJdgismh8PEqg51EjD82OaSgcjWp3Ujn8WmKUMA/h9wEvepY43b3O6DcBmB/U2e6YGYvhvIUxI0ZkGQZsC6zj0r/h8B7jUsr4Fot2cYpnE/GUE+khJifCm0UkIPKlgDStxprXOHCwtgDueDtMow1EtcuAAPJuqEXb7CTaRxVWTZ7iwkYm5tOKmXguVn+MiKy3RxZ41MA9Xd3oOQFHNRQEEN91mP1fNgqMPESzVUmJbBrQPt/+RLQhfMaFJIqtfG7sDeI8sA4itcoj8AKTpUhfhUtuS0q+W30cMY/70i1YBcOgRgzVwfIfECVtO5vm4D4ntdebCcQW3fuj7dCmMtHj04ha9P+7Czeo4LCVLcJ7z4Y0BdrIYV9ZnJYBw3mCK3RLZ99/qGHBesNqrY1SCuU5ZnS1h7T2fdQECmsYYqA2fgvFThKjpB9id/7KNeiWuF3sgD5K7Czv8veWqg4ewCZEqZ7B8BXZZwVYzrFEqsONLu9qiofc6J62A7qT4fM35rfoHNO2kFHgbJF3dYrbcT5y+gZYxN9RKsJuL7uBgATlbqSpELGzKhzXGqCqiJ918Ji+k2hsLbUc6vmSdSV7JCw+6Yr0UfTDd7eFL2VmZyV8/Zy2go4UsXd2Xx+3s22ZbZxUULDdxq1T0/+pIuBHzNLhjxmfI0qQK1NOI\",\"iv\":\"jLsJjzIjzlZvKOnF4lHejQ==\",\"salt\":\"p/6m1lrdIB8G88iwE+cUFO/B7sTDXcJ0ERfzSDIHZZc=\"}")]
    public void Decrypt_WithValidPasswordAndPayload_ReturnsDecryptedText(string password, string payload)
    {
        // Act
        var decryptedText = _crypto.Decrypt(password, payload);

        // Assert
        Assert.NotNull(decryptedText);
        Assert.NotEmpty(decryptedText);
        Assert.NotEqual(payload, decryptedText);

        _output.WriteLine(decryptedText);
    }

    [Theory]
    [InlineData(new byte[] { 110, 97, 105, 118, 101, 32, 118, 101, 110, 100, 111, 114, 32, 98, 111, 110, 117, 115, 32, 114, 101, 102, 108, 101, 99, 116, 32, 100, 111, 99, 117, 109, 101, 110, 116, 32, 114, 101, 99, 121, 99, 108, 101, 32, 99, 97, 116, 101, 103, 111, 114, 121, 32, 100, 101, 99, 108, 105, 110, 101, 32, 103, 97, 114, 98, 97, 103, 101, 32, 100, 101, 99, 111, 114, 97, 116, 101, 32, 100, 97, 121, 32, 97, 119, 102, 117, 108 })]
    public void MnemonicBytesToString_ReturnsValidString(byte[] mnemonic)
    {
        // Act
        var result = _crypto.MnemonicBytesToString(mnemonic);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);

        _output.WriteLine(result);
    }
}