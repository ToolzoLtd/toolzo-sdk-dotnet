using ToolzoApiImplementations.DTO.Common;

namespace ToolzoApiImplementations.DTO.PaymentMethods.Cards;

public class CardsPaymentRequest
{
    public string   OrderId     { get; set; }
    public long     Amount      { get; set; }
    public string   Currency    { get; set; }
    public string   Description { get; set; }
    public bool     RebillFlag  { get; set; }
    public string   ReturnUrl   { get; set; }
    public CardInfo CardInfo    { get; set; }
}

public class CardsPaymentResponse
{
    public long   TransactionId { get; set; }
    public string PaymentUrl    { get; set; }
}