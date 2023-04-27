using Newtonsoft.Json.Linq;

namespace ToolzoApiImplementations.DTO.Infrastructure;

public class RequestMessage
{
    public string   Type          { get; set; }
    public DateTime TimeStamp     { get; set; }
    public TimeSpan TTL           { get; set; }
    public string   CorrelationId { get; set; }
    public JObject  Payload       { get; set; }
}

public class DataRequest<T>
{
    public string Type       { get; set; }
    public string ApiVersion { get; set; }
    public T      Payload    { get; set; }
}