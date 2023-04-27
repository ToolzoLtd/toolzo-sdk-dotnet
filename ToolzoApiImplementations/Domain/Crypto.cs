using System.Security.Cryptography;
using System.Text;

namespace ToolzoApiImplementations.Domain;

public class Crypto
{
    private readonly string   _secretKey;
    private readonly Encoding _encoding;

    public Crypto(string secretKey, Encoding? encoding = null)
    {
        _secretKey = secretKey;
        _encoding  = encoding ?? Encoding.UTF8;
    }

    public (string signature, string payload ) GetSignature(string body)
    {
        using var hmac = CreateHMac(_secretKey);

        var bytes = GetBytes(body);

        var signature = ToBase64(hmac.ComputeHash(bytes));

        return (signature, ToBase64(bytes));
    }

    public bool ValidateSignature(string payload, string signature)
    {
        using var hmac              = CreateHMac(_secretKey);
        var       binaryPayload     = Convert.FromBase64String(payload);
        var       payloadSignature  = hmac.ComputeHash(binaryPayload);
        var       computedSignature = Convert.FromBase64String(signature);

        return CryptographicOperations.FixedTimeEquals(payloadSignature, computedSignature);
    }

    private        byte[] GetBytes(string   request)   => _encoding.GetBytes(request);
    private static byte[] FromBase64(string value)     => Convert.FromBase64String(value);
    private static string ToBase64(byte[]   value)     => Convert.ToBase64String(value);
    private static HMAC   CreateHMac(string secretKey) => new HMACSHA1(FromBase64(secretKey));
}