using ToolzoApiImplementations.DTO.Common;

namespace ToolzoApiImplementations.DTO.PaymentMethods.Cards;

public class CardsPayoutRequest
{
    public string   OrderId     { get; set; }
    public long     Amount      { get; set; }
    public string   Currency    { get; set; }
    public string   Description { get; set; }
    public CardInfo CardInfo    { get; set; }
}

public class CardsPayoutResponse
{
    public long   TransactionId { get; set; }
    public string OrderId       { get; set; }
}