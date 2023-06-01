using System.Text.Json.Serialization;

namespace MetaMaskCrypto;

internal class Payload
{
    [JsonPropertyName("data")]
    [JsonInclude]
    public string Data { get; private set; }
    [JsonPropertyName("iv")]
    [JsonInclude]
    public string IV { get; private set; }
    [JsonPropertyName("salt")]
    [JsonInclude]
    public string Salt { get; private set; }

    public Payload(string data, string iv, string salt)
    {
        Data = data;
        IV = iv;
        Salt = salt;
    }
}
