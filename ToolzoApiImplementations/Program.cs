using ToolzoApiImplementations.Domain;
using ToolzoApiImplementations.Examples;

namespace ToolzoApiImplementations;

public static class Program
{
    public static async Task Main()
    {
        var config = new AuthConfig
        {
            ApiKey     = "your apikey",
            SecretKey  = "your secret key",
            Host       = "pay.toolzo.com",
            ApiVersion = "1"
        };
        
        #region Cards

        // await ToolzoApiExamples.CardsPaymentAsync(config);
        // await ToolzoApiExamples.CardsPayoutAsync(config);
        // await ToolzoApiExamples.CardsRebillAsync(config);
        // await ToolzoApiExamples.CardsRefundAsync(config);
        // await ToolzoApiExamples.CardsReversalAsync(config);
        // await ToolzoApiExamples.BankTransferChinaPayAsync(config);

        #endregion

        #region BankTransfer

        // TODO: Terminal Setting
        // await ToolzoApiExamples.BankTransferEuPaymentAsync(config);
        
        // TODO: Implement this
        // await ToolzoApiExamples.BankTransferChinaPaymentAsync(config);
        
        // TODO: set PaymentRoutes 
        // await ToolzoApiExamples.BankTransferChinaPayoutAsync(config);

        #endregion

        #region Boleto

        // await ToolzoApiExamples.BoletoPaymentAsync(config);
        // await ToolzoApiExamples.BoletoPayoutAsync(config);

        #endregion

        #region Crypto

        // await ToolzoApiExamples.CryptoPaymentAsync(config);
        // await ToolzoApiExamples.CryptoPayoutAsync(config);

        #endregion

        #region DepositExpress

        // await ToolzoApiExamples.DepositExpressPaymentAsync(config);

        #endregion

        #region Lottery

        // await ToolzoApiExamples.LotteryPaymentAsync(config);

        #endregion

        #region PicPay

        // await ToolzoApiExamples.PicPayPaymentAsync(config);

        #endregion

        #region Pix

        // await ToolzoApiExamples.PixPaymentAsync(config);

        #endregion

        #region Sepa

        // await ToolzoApiExamples.SepaPayoutAsync(config);

        #endregion

        #region GetOrderState

        // await ToolzoApiExamples.GetOrderStateAsync(config, "329766a7-8778-4920-932f-f38d3276717f");

        #endregion

        Console.ReadKey();
    }
}