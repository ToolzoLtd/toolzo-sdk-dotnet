namespace ToolzoApiImplementations.DTO.Common;

public class ApiResult<T>
{
    public T            Result { get; set; }
    public PaymentError Error  { get; set; }
}