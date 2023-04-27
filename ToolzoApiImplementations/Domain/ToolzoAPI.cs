using Newtonsoft.Json.Linq;
using ToolzoApiImplementations.DTO.Common;
using ToolzoApiImplementations.DTO.Infrastructure;
using ToolzoApiImplementations.DTO.PaymentMethods.BankTransfer;
using ToolzoApiImplementations.DTO.PaymentMethods.Boleto;
using ToolzoApiImplementations.DTO.PaymentMethods.Cards;
using ToolzoApiImplementations.DTO.PaymentMethods.Crypto;
using ToolzoApiImplementations.DTO.PaymentMethods.DepositExpress;
using ToolzoApiImplementations.DTO.PaymentMethods.GetOrderState;
using ToolzoApiImplementations.DTO.PaymentMethods.Lottery;
using ToolzoApiImplementations.DTO.PaymentMethods.PicPay;
using ToolzoApiImplementations.DTO.PaymentMethods.Pix;
using ToolzoApiImplementations.DTO.PaymentMethods.Sepa;

namespace ToolzoApiImplementations.Domain;

public class ToolzoApi
{
    private readonly string       _apiVersion;
    private readonly ToolzoClient _toolzoClient;

    public ToolzoApi(AuthConfig config)
    {
        _apiVersion   = config.ApiVersion;
        _toolzoClient = new ToolzoClient(config);
    }

    #region Cards

    public async Task CardsPaymentAsync(CardsPaymentRequest request, Action<CardsPaymentResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.Cards.Payment, _apiVersion, request, result, error);
    }

    public async Task CardsPayoutAsync(CardsPayoutRequest request, Action<CardsPayoutResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.Cards.Payout, _apiVersion, request, result, error);
    }

    public async Task CardsRebillAsync(CardsRebillRequest request, Action<CardsRebillResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.Cards.Rebill, _apiVersion, request, result, error);
    }

    public async Task CardsRefundAsync(CardsRefundRequest request, Action<CardsRefundResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.Cards.Refund, _apiVersion, request, result, error);
    }

    public async Task CardsReversalAsync(CardsReversalRequest request, Action<CardsReversalResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.Cards.Reversal, _apiVersion, request, result, error);
    }

    #endregion

    #region BankTransfer

    public async Task BankTransferEuPaymentAsync(BankTransferEuPaymentRequest request, Action<BankTransferEuPaymentResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.BankTransfer.EuPayment, _apiVersion, request, result, error);
    }

    public async Task BankTransferChinaPaymentAsync(BankTransferChinaPaymentRequest request, Action<BankTransferChinaPaymentResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.BankTransfer.ChinaPay, _apiVersion, request, result, error);
    }

    public async Task BankTransferChinaPayoutAsync(BankTransferChinaPayoutRequest request, Action<BankTransferChinaPayouttResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.BankTransfer.ChinaPayout, _apiVersion, request, result, error);
    }

    #endregion

    #region Boleto

    public async Task BoletoPaymentAsync(BoletoPaymentRequest request, Action<BoletoPaymentResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.Boleto.Payment, _apiVersion, request, result, error);
    }

    public async Task BoletoPayoutAsync(BoletoPayoutRequest request, Action<BoletoPayoutResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.Boleto.Payout, _apiVersion, request, result, error);
    }

    #endregion

    #region Crypto

    public async Task CryptoPaymentAsync(CryptoPaymentRequest request, Action<CryptoPaymentResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.Crypto.Payment, _apiVersion, request, result, error);
    }

    public async Task CryptoPayoutAsync(CryptosPayoutRequest request, Action<CryptoPayoutResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.Crypto.Payout, _apiVersion, request, result, error);
    }

    #endregion

    #region DepositExpress

    public async Task DepositExpressPaymentAsync(DepositExpressPaymentRequest request, Action<DepositExpressPaymentResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.DepositExpress.Payment, _apiVersion, request, result, error);
    }

    #endregion

    #region Lottery

    public async Task LotteryPaymentAsync(LotteryPaymentRequest request, Action<LotteryPaymentResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.Lottery.Payment, _apiVersion, request, result, error);
    }

    #endregion

    #region PicPay

    public async Task PicPayPaymentAsync(PicPayPaymentRequest request, Action<PicPayPaymentResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.PicPay.Payment, _apiVersion, request, result, error);
    }

    #endregion

    #region Pix

    public async Task PixPaymentAsync(PixPaymentRequest request, Action<PixPaymentResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.Pix.Payment, _apiVersion, request, result, error);
    }

    #endregion

    #region Sepa

    public async Task SepaPayoutAsync(SepaPayoutRequest request, Action<SepaPayoutResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.Sepa.Payment, _apiVersion, request, result, error);
    }

    #endregion

    #region GetOrderState

    public async Task GetOrderStateAsync(GetOrderStateRequest request, Action<GetOrderStateResponse> result, Action<PaymentError> error)
    {
        await ExecuteAsync(PaymentMethods.GetOrderState, _apiVersion, request, result, error);
    }

    #endregion

    private async Task ExecuteAsync<TRequest, TResponse>(string type, string apiVersion, TRequest request, Action<TResponse> result, Action<PaymentError> error)
    {
        var requestMessage = new RequestMessage()
        {
            Type          = MessageTypes.Request,
            CorrelationId = Guid.NewGuid().ToString(),
            TimeStamp     = DateTime.UtcNow,
            TTL           = TimeSpan.FromMinutes(2),
            Payload = JObject.FromObject(new DataRequest<TRequest>()
            {
                Type       = type,
                ApiVersion = apiVersion,
                Payload    = request,
            })
        };

        LogToConsole(requestMessage);

        var responseMessage = await _toolzoClient.SendAsync(requestMessage);

        LogToConsole(responseMessage);

        if (responseMessage.Type == MessageTypes.Response) result(responseMessage.Payload.ToObject<TResponse>()!);
        if (responseMessage.Type == MessageTypes.Error) error(responseMessage.Payload.ToObject<PaymentError>()!);
    }

    private static void LogToConsole<T>(T data)
    {
        Console.WriteLine(typeof(T).Name);
        Console.WriteLine(Serializer.Serialize(data, true));
    }
}