using ToolzoApiImplementations.DTO.Common;

namespace ToolzoApiImplementations.DTO.PaymentMethods.GetOrderState;

public class GetOrderStateRequest
{
    public string OrderId { get; set; }
}

public class GetOrderStateResponse
{
    public string       ReferenceCode { get; set; }
    public Order        Order        { get; set; }
    public CardInfo     CardInfo     { get; set; }
    public ClientInfo   ClientInfo   { get; set; }
    public BinInfo      BinInfo      { get; set; }
    public PaymentError PaymentError { get; set; }
}