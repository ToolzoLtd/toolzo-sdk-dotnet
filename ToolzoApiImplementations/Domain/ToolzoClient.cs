using System.Text;
using ToolzoApiImplementations.DTO.Infrastructure;

namespace ToolzoApiImplementations.Domain;

public class ToolzoClient
{
    private readonly AuthConfig _config;

    public ToolzoClient(AuthConfig config)
    {
        _config = config;
    }

    public async Task<ResponseMessage> SendAsync(RequestMessage requestMessage)
    {
        using var httpClient = new HttpClient();

        var httpRequestMessage = CreateHttpRequestMessage(requestMessage);

        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
        var content             = await httpResponseMessage.Content.ReadAsStringAsync();

        var responseMessage = GetResponseMessage(content);

        return responseMessage;
    }

    private ResponseMessage GetResponseMessage(string content)
    {
        var httpMessage = Serializer.Deserialize<HttpMessage>(content)!;

        var crypto = new Crypto(_config.SecretKey);
        if (!crypto.ValidateSignature(httpMessage.Payload, httpMessage.Signature))
            throw new Exception("Invalid signature");

        var responseBytes   = Convert.FromBase64String(httpMessage.Payload);
        var responseString  = Encoding.UTF8.GetString(responseBytes);
        var responseMessage = Serializer.Deserialize<ResponseMessage>(responseString);

        return responseMessage!;
    }

    private HttpRequestMessage CreateHttpRequestMessage(RequestMessage requestMessage)
    {
        var crypto = new Crypto(_config.SecretKey);

        var messageString = Serializer.Serialize(requestMessage);
        var (signature, payload) = crypto.GetSignature(messageString);

        var httpMessage = new HttpMessage
        {
            ApiKey    = _config.ApiKey,
            Payload   = payload,
            Signature = signature,
        };

        var httpMessageString = Serializer.Serialize(httpMessage);
        var content           = new StringContent(httpMessageString);
        var uri               = new Uri(new Uri(_config.Host), "/api/v1/");

        var httpRequestMessage = new HttpRequestMessage
        {
            Method     = HttpMethod.Post,
            Content    = content,
            RequestUri = uri
        };

        return httpRequestMessage;
    }
}