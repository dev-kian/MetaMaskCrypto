<p align="center">
  <img width="40%" src="screens/metamask.webp"> <br>
  <b>MataMaskCrypto</b> <br>
  <i>MetaMask Vault Decryptor.</i>
</p>

MetaMaskCrypto is a C# library that provides functionality for decrypting vaults encrypted by MetaMask. It allows you to securely access encrypted private keys and other sensitive information stored in your MetaMask vault.

## Features

- Decryption of MetaMask vaults
- Retrieval of encrypted mnemonic phrase and other sensitive information

## Installation

MetaMaskCrypto can be easily installed via [NuGet](https://www.nuget.org/packages/MetaMaskCrypto). Follow the steps below to install the library in your project:

1. Open the NuGet Package Manager Console in Visual Studio or the terminal in your project directory.
2. Run one of the following commands:

```bash
Install-Package MetaMaskCrypto
```
## Usage

To use MetaMaskCrypto in your project, follow the example code below:

### Encryption

```cs
// Initialize MetaMaskCrypto
MetaCrypto crypto = new();

// The password used for encryption
string password = "<Your Password>";
// The payload or data to be encrypted
string payload = "<Your Payload>";

// Encrypt the payload using the provided password
string encryptedPayload = crypto.Encrypt(password, payload);

// Print the encrypted payload
Console.WriteLine(encryptedPayload);
```


### Decryption

```cs
// Initialize MetaMaskCrypto
MetaCrypto crypto = new();

// The password used for decryption
string password = "Admin231@";
// The payload or data to be decrypted
string payload = "{\"data\":\"0UTpH53VzgKxrOF3aFBYyByZNC6Xy7Xp8A3pWd04GnW7ei8s6bVgkUNNSwnTei96pCxGd3CH26CBnqmuXj4QLd/rEyUocpplR6sEXYCpt+QvS951e8QwsgzWNnEBHJjw0LdiFathFNOBt8pBhBTX72YJdgismh8PEqg51EjD82OaSgcjWp3Ujn8WmKUMA/h9wEvepY43b3O6DcBmB/U2e6YGYvhvIUxI0ZkGQZsC6zj0r/h8B7jUsr4Fot2cYpnE/GUE+khJifCm0UkIPKlgDStxprXOHCwtgDueDtMow1EtcuAAPJuqEXb7CTaRxVWTZ7iwkYm5tOKmXguVn+MiKy3RxZ41MA9Xd3oOQFHNRQEEN91mP1fNgqMPESzVUmJbBrQPt/+RLQhfMaFJIqtfG7sDeI8sA4itcoj8AKTpUhfhUtuS0q+W30cMY/70i1YBcOgRgzVwfIfECVtO5vm4D4ntdebCcQW3fuj7dCmMtHj04ha9P+7Czeo4LCVLcJ7z4Y0BdrIYV9ZnJYBw3mCK3RLZ99/qGHBesNqrY1SCuU5ZnS1h7T2fdQECmsYYqA2fgvFThKjpB9id/7KNeiWuF3sgD5K7Czv8veWqg4ewCZEqZ7B8BXZZwVYzrFEqsONLu9qiofc6J62A7qT4fM35rfoHNO2kFHgbJF3dYrbcT5y+gZYxN9RKsJuL7uBgATlbqSpELGzKhzXGqCqiJ918Ji+k2hsLbUc6vmSdSV7JCw+6Yr0UfTDd7eFL2VmZyV8/Zy2go4UsXd2Xx+3s22ZbZxUULDdxq1T0/+pIuBHzNLhjxmfI0qQK1NOI\",\"iv\":\"jLsJjzIjzlZvKOnF4lHejQ==\",\"salt\":\"p/6m1lrdIB8G88iwE+cUFO/B7sTDXcJ0ERfzSDIHZZc=\"}";

// Decrypt the payload using the provided password
string encryptedPayload = crypto.Decrypt(password, payload);

// Print the decrypted payload
Console.WriteLine(encryptedPayload);
```

## Contributing

Contributions to MetaMaskCrypto are welcome! If you find any issues or have suggestions for improvements, please feel free to open an issue or submit a pull request on the [GitHub repository](https://github.com/dev-kian/MetaMaskCrypto/issues).

Please ensure that your contributions adhere to the coding standards, and include relevant documentation and tests if applicable.

## License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). See the [LICENSE](https://github.com/dev-kian/MetaMaskCrypto/blob/main/LICENSE.txt) file for more details.
