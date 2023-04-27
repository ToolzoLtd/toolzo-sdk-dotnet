namespace ToolzoApiImplementations.DTO.PaymentMethods.Pix;

public class PixPaymentRequest
{
    public string OrderId     { get; set; }
    public long   Amount      { get; set; }
    public string Currency    { get; set; }
    public string Description { get; set; }
    public bool   RebillFlag  { get; set; }
    public string ReturnUrl   { get; set; }
}

public class PixPaymentResponse
{
    public long   TransactionId { get; set; }
    public string PaymentUrl    { get; set; }
}