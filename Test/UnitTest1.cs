using MetaMaskCrypto;
using Xunit.Abstractions;

namespace Test
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _output;
        public UnitTest1(ITestOutputHelper output)
        {
            _output=output;
        }

        [Fact]
        public void Test1()
        {
            var wallet = "{\"data\":\"2OfFEWVvaOUy7yVxUmez7m9Ur3wvWCDgdBseGKTJSkFbVrSgegE+inAmEG5t6vuY8R1KwBVy2Ow6JHKTTSOAQjZa4P6fiDSuMcoyRP01ynP6viRlVrkmq2dhQZDz7Oo1h29vx0kqb1l20h8kVZGxgsusUpS3XMw8nisH8CGtSeTSvbL2D/RNR2gwtiYUVPPqBWhRLnqqY3xM3POZng0qRjSdTszQ3lJaXB0cjqj7RUYUI1d0yeDbO1pC7z5NtpDrVlnWCBDmaFrtEPUXv37B8ehYm4zztKfD6lJ0db+6qcjYkTdNhgIKNy7dk8fXMRn49jTZ6trbo8PdfBnjQ8rpEWltjzXPLDNz3DuBGg0hBqrAu64Czooa3GwvMStzdB0ZjM+PX6hVhe7hBRgy5LGwVcgxAbqADE7jKUWcgCc+wMVBxGT5fxu/pY9Kk2WGYkDIDLKhKiW0iBK3aibddhpUfC2Ti/0aEbt0X4nTBFxB4rZ0PtxGX25MOKmUDMCzN2qvUIILOKISkasTekwfaBQdDgmbTpXXruKzDYVhwR8/lXF+EAZ0Cn9DlY10du4kJminMEyYxOZCj1jyNflzXo0sa9jRRO8yP8yii2haxAzq21snVoA/zmmZza/C4yhK0LuzO1hnyTtBgqR8DjO81xpzLpOpVkxwf1XcmKK4Uffo9V+KFPD+Ldot/i4+64zi3013YOajtVXlLb541CWpbGlu2fKqAkmujQXCIN1ADu9vfKxxVKp5nx2BBE+NvCwVflxwELs8Df9LFdDF2510v/9MaqWilMAdyB183Omfeuek7sutNYUlR0I3wmj3\",\"iv\":\"uOvti0Cg/hQgHCeLhbXuUQ==\",\"salt\":\"86Goy7s05npA1H/ZyFIaNLWk6DU/yM082gim20vaE3A=\"}";
            wallet = "{\"data\":\"0UTpH53VzgKxrOF3aFBYyByZNC6Xy7Xp8A3pWd04GnW7ei8s6bVgkUNNSwnTei96pCxGd3CH26CBnqmuXj4QLd/rEyUocpplR6sEXYCpt+QvS951e8QwsgzWNnEBHJjw0LdiFathFNOBt8pBhBTX72YJdgismh8PEqg51EjD82OaSgcjWp3Ujn8WmKUMA/h9wEvepY43b3O6DcBmB/U2e6YGYvhvIUxI0ZkGQZsC6zj0r/h8B7jUsr4Fot2cYpnE/GUE+khJifCm0UkIPKlgDStxprXOHCwtgDueDtMow1EtcuAAPJuqEXb7CTaRxVWTZ7iwkYm5tOKmXguVn+MiKy3RxZ41MA9Xd3oOQFHNRQEEN91mP1fNgqMPESzVUmJbBrQPt/+RLQhfMaFJIqtfG7sDeI8sA4itcoj8AKTpUhfhUtuS0q+W30cMY/70i1YBcOgRgzVwfIfECVtO5vm4D4ntdebCcQW3fuj7dCmMtHj04ha9P+7Czeo4LCVLcJ7z4Y0BdrIYV9ZnJYBw3mCK3RLZ99/qGHBesNqrY1SCuU5ZnS1h7T2fdQECmsYYqA2fgvFThKjpB9id/7KNeiWuF3sgD5K7Czv8veWqg4ewCZEqZ7B8BXZZwVYzrFEqsONLu9qiofc6J62A7qT4fM35rfoHNO2kFHgbJF3dYrbcT5y+gZYxN9RKsJuL7uBgATlbqSpELGzKhzXGqCqiJ918Ji+k2hsLbUc6vmSdSV7JCw+6Yr0UfTDd7eFL2VmZyV8/Zy2go4UsXd2Xx+3s22ZbZxUULDdxq1T0/+pIuBHzNLhjxmfI0qQK1NOI\",\"iv\":\"jLsJjzIjzlZvKOnF4lHejQ==\",\"salt\":\"p/6m1lrdIB8G88iwE+cUFO/B7sTDXcJ0ERfzSDIHZZc=\"}";
            wallet = "{\"data\":\"YbtyL/uv0nhaW1vJth\\u002BPcO/WpJVtqa1UFXnCYpA6HxyDMejf8KOJBoEKL4xQ2gSfvIi2x5BckVJl\\u002BRTmc15m/I1HDJlLhhHsCoH0EH09CpYfaH191ed82A5ssDp07XgqDhl9pNbcLJKE08JBjA85jM2RSfXoNKQ6acskS5ddAQK0DzvFJoAQK3RHLm3k8TzeyhW9DsIyrUY3n/GAXzVhMksBTnkWhzYvor5pDxJgfJfR4faLzFicp50t4PuoSVu7qYd0HDLTpczZdziyZm/Nn2HTOceG02UIWJgjTLTH2nCfHwNcPF5vHkS/sS3m/evY7NJMuhmmTnd4eFtUYWOTpDdUz/xsxBg\\u002BHrgoo2t5LB/5vytvl7i079NVdtu0NXIVr36WPC3PBBdhv29OPewi3MhiHIWW8RFt7yhKQBwTDjkk5EkI4mJFTGxZPSAScpDHri3PMgrJ5ABY5D2p2QlUwHgWEFXQnQdikskcPUeqaojxlqIwlH\\u002BhUj64v0UvMnfQ4DmaBkxP9TOe2DYcH3tcTINAoRBxwZ32f1EPTjw6kn5Q3gys2Zfijst4aLvBVkLdczBLmXCpewsX5DQr9G7yZkT2dts13V5PO0f/1pTiUwSpc5Q/jysijWw1qxF/OuwIY/IJMjRnZr/DC5Z2M0FuQ57\\u002BqYI\\u002B5m4G1zNjs138tRBBAPSrqv4ypRO1Noa9UpAdaJAuLVb\\u002BhBbl8FJWNP/zUigdOVgIUDXVVbLlDTC8zQ3bcXeeErtrCTtdEoIkuYd6POoAwuaLFjXWfUroZdVFScxNXVgAJDSla8vXDYSgyXEem5UKFL7EOsA5\",\"iv\":\"U9TR0GCB1n9L/Z4VPI9Dqg==\",\"salt\":\"f8TbHL7tXh7KQC6fKbh14\\u002BTSBK1HguUxguN1T6pEIm8=\"}";

            MetaCrypto crypto = new();

            var decryptedText = crypto.Decrypt("Admin231@", wallet);

            Assert.NotNull(decryptedText);
            Assert.NotEmpty(decryptedText);
            Assert.NotEqual(wallet, decryptedText);

            _output.WriteLine(decryptedText);
        }

        [Fact]
        public void Test2()
        {
            var payload = "[{\"type\":\"HD Key Tree\",\"data\":{\"mnemonic\":[110,97,105,118,101,32,118,101,110,100,111,114,32,98,111,110,117,115,32,114,101,102,108,101,99,116,32,100,111,99,117,109,101,110,116,32,114,101,99,121,99,108,101,32,99,97,116,101,103,111,114,121,32,100,101,99,108,105,110,101,32,103,97,114,98,97,103,101,32,100,101,99,111,114,97,116,101,32,100,97,121,32,97,119,102,117,108],\"numberOfAccounts\":3,\"hdPath\":\"m/44'/60'/0'/0\"}},{\"type\":\"Ledger Hardware\",\"data\":{\"hdPath\":\"m/44'/60'/0'\",\"accounts\":[],\"accountDetails\":{},\"bridgeUrl\":\"https://metamask.github.io/eth-ledger-bridge-keyring\",\"implementFullBIP44\":false}}]";
            MetaCrypto crypto = new();

            var encryptedText = crypto.Encrypt("Admin231@", payload);

            Assert.NotNull(encryptedText);
            Assert.NotEmpty(encryptedText);
            Assert.NotEqual(payload, encryptedText);

            _output.WriteLine(encryptedText);
        }
    }
}