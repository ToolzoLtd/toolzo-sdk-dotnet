namespace ToolzoApiImplementations.DTO.PaymentMethods.Crypto;

public class CryptosPayoutRequest
{
    public string OrderId   { get; set; }
    public long   Amount    { get; set; }
    public string Currency  { get; set; }
    public string ReturnUrl { get; set; }
}

public class CryptoPayoutResponse
{
    public long   TransactionId { get; set; }
    public string OrderId       { get; set; }
}