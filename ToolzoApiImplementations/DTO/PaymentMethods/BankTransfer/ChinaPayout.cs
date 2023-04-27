using ToolzoApiImplementations.DTO.Common;

namespace ToolzoApiImplementations.DTO.PaymentMethods.BankTransfer;

public class BankTransferChinaPayoutRequest
{
    public string   OrderId     { get; set; }
    public long     Amount      { get; set; }
    public string   Currency    { get; set; }
    public string   BankCode { get; set; }
    public string   RecipientAccount   { get; set; }
    public ClientInfoChinaPayout ClientInfo    { get; set; }
}

public class BankTransferChinaPayouttResponse
{
    public long   TransactionId { get; set; }
    public string PaymentUrl    { get; set; }
}