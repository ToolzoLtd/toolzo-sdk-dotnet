using Newtonsoft.Json.Linq;

namespace ToolzoApiImplementations.DTO.Infrastructure;

public class ResponseMessage
{
    public string   Type              { get; set; }
    public DateTime TimeStamp         { get; set; }
    public string   CorrelationId     { get; set; }
    public TimeSpan ExecutionDuration { get; set; }
    public JObject  Payload           { get; set; }
}