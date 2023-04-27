namespace ToolzoApiImplementations.DTO.PaymentMethods.Sepa;

public class SepaPayoutRequest
{
    public string OrderId   { get; set; }
    public long   Amount    { get; set; }
    public string Currency  { get; set; }
    public string ReturnUrl { get; set; }
}

public class SepaPayoutResponse
{
    public long   TransactionId { get; set; }
    public string OrderId       { get; set; }
}