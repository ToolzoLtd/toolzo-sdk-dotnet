namespace ToolzoApiImplementations.DTO.PaymentMethods.Cards;

public class CardsRebillRequest
{
    public string OrderId   { get; set; }
    public long   Amount    { get; set; }
    public string Currency  { get; set; }
    public long   BindingId { get; set; }
}

public class CardsRebillResponse
{
    public long   TransactionId { get; set; }
    public string PaymentUrl    { get; set; }
}

