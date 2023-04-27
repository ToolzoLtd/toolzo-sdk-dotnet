namespace ToolzoApiImplementations.DTO.PaymentMethods.BankTransfer;

public class BankTransferEuPaymentRequest
{
    public string OrderId   { get; set; }
    public long   Amount    { get; set; }
    public string Currency  { get; set; }
    public string ReturnUrl { get; set; }
}

public class BankTransferEuPaymentResponse
{
    public long   TransactionId { get; set; }
    public string PaymentUrl    { get; set; }
}