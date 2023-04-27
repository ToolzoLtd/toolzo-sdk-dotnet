namespace ToolzoApiImplementations.DTO.PaymentMethods.Cards;

public class CardsRefundRequest
{
    public string OrderId       { get; set; }
    public string ParentOrderId { get; set; }
    public long   Amount        { get; set; }
    public string Description   { get; set; }
}

public class CardsRefundResponse
{
    public long   TransactionId { get; set; }
    public string PaymentUrl    { get; set; }
}