using ToolzoApiImplementations.DTO.Common;

namespace ToolzoApiImplementations.DTO.PaymentMethods.BankTransfer;

public class BankTransferChinaPaymentRequest
{
    public string   OrderId     { get; set; }
    public long     Amount      { get; set; }
    public string   Currency    { get; set; }
    public string   Description { get; set; }
    public bool     RebillFlag  { get; set; }
    public string   ReturnUrl   { get; set; }
    public ClientInfoChinaPay ClientInfo { get; set; }
}

public class BankTransferChinaPaymentResponse
{
    public long   TransactionId { get; set; }
    public string PaymentUrl    { get; set; }
}