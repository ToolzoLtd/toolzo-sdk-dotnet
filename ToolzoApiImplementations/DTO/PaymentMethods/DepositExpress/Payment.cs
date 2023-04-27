namespace ToolzoApiImplementations.DTO.PaymentMethods.DepositExpress;

public class DepositExpressPaymentRequest
{
    public string OrderId     { get; set; }
    public long   Amount      { get; set; }
    public string Currency    { get; set; }
    public string ReturnUrl   { get; set; }
}

public class DepositExpressPaymentResponse
{
    public long   TransactionId { get; set; }
    public string PaymentUrl    { get; set; }
}