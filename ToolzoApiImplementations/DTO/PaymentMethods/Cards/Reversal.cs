namespace ToolzoApiImplementations.DTO.PaymentMethods.Cards;

public class CardsReversalRequest
{
    public string OrderId       { get; set; }
    public string ParentOrderId { get; set; }
    public string Description   { get; set; }
}

public class CardsReversalResponse
{
    public long   TransactionId { get; set; }
    public string PaymentUrl    { get; set; }
}