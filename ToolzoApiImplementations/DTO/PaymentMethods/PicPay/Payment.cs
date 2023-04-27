namespace ToolzoApiImplementations.DTO.PaymentMethods.PicPay;

public class PicPayPaymentRequest
{
    public string OrderId     { get; set; }
    public long   Amount      { get; set; }
    public string Currency    { get; set; }
    public string Description { get; set; }
    public string ReturnUrl   { get; set; }
}

public class PicPayPaymentResponse
{
    public long   TransactionId { get; set; }
    public string PaymentUrl    { get; set; }
}