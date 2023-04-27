namespace ToolzoApiImplementations.DTO.Infrastructure;

public class HttpMessage
{
    public string ApiKey    { get; set; }
    public string Payload   { get; set; }
    public string Signature { get; set; }
}