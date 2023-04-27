namespace ToolzoApiImplementations.DTO.Common;

public class Order
{
    public long      TransactionId           { get; set; }
    public string    OrderId                 { get; set; }
    public DateTime? DateTime                { get; set; }
    public DateTime? ExecDateTime            { get; set; }
    public long      Amount                  { get; set; }
    public string    Currency                { get; set; }
    public string    State                   { get; set; }
    public string    StateDescription        { get; set; }
    public string    PresentState            { get; set; }
    public string    PresentStateDescription { get; set; }
    public long?     LinkId                  { get; set; }
}