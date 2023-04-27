namespace ToolzoApiImplementations.DTO.Common;

public class CardInfo
{
    public string CardNumber      { get; set; }
    public string CardHolder      { get; set; }
    public string ExpirationYear  { get; set; }
    public string ExpirationMonth { get; set; }
    public string Cvv             { get; set; }
    public long?  BindingId       { get; set; }
}