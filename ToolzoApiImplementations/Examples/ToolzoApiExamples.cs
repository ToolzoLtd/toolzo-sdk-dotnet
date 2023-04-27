using ToolzoApiImplementations.Domain;
using ToolzoApiImplementations.DTO.Common;
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

namespace ToolzoApiImplementations.Examples;

public static class ToolzoApiExamples
{
    #region Cards

    public static async Task CardsPaymentAsync(AuthConfig config)
    {
        var request = new CardsPaymentRequest
        {
            OrderId     = Guid.NewGuid().ToString(),
            Amount      = 10000,
            Currency    = "USD",
            RebillFlag  = true,
            Description = "TEST",
            ReturnUrl   = "http://google.com",
            CardInfo = new CardInfo
            {
                CardNumber      = "4111111111111111",
                CardHolder      = "XXX XXX",
                ExpirationMonth = "12",
                ExpirationYear  = "2024",
                Cvv             = "123"
            }
        };

        var toolzoApi = new ToolzoApi(config);

        await toolzoApi.CardsPaymentAsync(request,
                                          result =>
                                          {
                                              //Your success logic here
                                          },
                                          error =>
                                          {
                                              //Your failed logic here
                                          });
    }

    public static async Task CardsPayoutAsync(AuthConfig config)
    {
        var request = new CardsPayoutRequest
        {
            OrderId     = Guid.NewGuid().ToString(),
            Amount      = 100000,
            Currency    = "USD",
            Description = "TEST",
            CardInfo = new CardInfo
            {
                CardNumber      = "4111111111111111",
                CardHolder      = "XXX XXX",
                ExpirationMonth = "12",
                ExpirationYear  = "2024",
                Cvv             = "123"
            }
        };
        var toolzoApi = new ToolzoApi(config);

        await toolzoApi.CardsPayoutAsync(request,
                                         result =>
                                         {
                                             //Your success logic here
                                         },
                                         error =>
                                         {
                                             //Your failed logic here
                                         });
    }

    public static async Task CardsRebillAsync(AuthConfig config)
    {
        var request = new CardsRebillRequest
        {
            OrderId  = Guid.NewGuid().ToString(),
            Amount   = 100000,
            Currency = "USD",
            BindingId = 2515694
        };

        var toolzoApi = new ToolzoApi(config);
        await toolzoApi.CardsRebillAsync(request,
                                         result =>
                                         {
                                             //Your success logic here
                                         },
                                         error =>
                                         {
                                             //Your failed logic here
                                         });
    }

    public static async Task CardsRefundAsync(AuthConfig config)
    {
        var request = new CardsRefundRequest
        {
            OrderId       = Guid.NewGuid().ToString(),
            ParentOrderId = "329766a7-8778-4920-932f-f38d3276717f",
            Amount        = 500,
            Description   = "TEST",
        };

        var toolzoApi = new ToolzoApi(config);
        await toolzoApi.CardsRefundAsync(request,
                                         result =>
                                         {
                                             //Your success logic here
                                         },
                                         error =>
                                         {
                                             //Your failed logic here
                                         });
    }

    public static async Task CardsReversalAsync(AuthConfig config)
    {
        var request = new CardsReversalRequest
        {
            OrderId       = Guid.NewGuid().ToString(),
            ParentOrderId = "put here parent orderId",
            Description   = "TEST",
        };

        var toolzoApi = new ToolzoApi(config);
        await toolzoApi.CardsReversalAsync(request,
                                           result =>
                                           {
                                               //Your success logic here
                                           },
                                           error =>
                                           {
                                               //Your failed logic here
                                           });
    }

    #endregion

    #region BankTransfer

    public static async Task BankTransferEuPaymentAsync(AuthConfig config)
    {
        var request = new BankTransferEuPaymentRequest
        {
            OrderId   = Guid.NewGuid().ToString(),
            Amount    = 10000,
            Currency  = "USD",
            ReturnUrl = "http://google.com",
        };

        var toolzoApi = new ToolzoApi(config);

        await toolzoApi.BankTransferEuPaymentAsync(request,
                                                   result =>
                                                   {
                                                       //Your success logic here
                                                   },
                                                   error =>
                                                   {
                                                       //Your failed logic here
                                                   });
    }

    public static async Task BankTransferChinaPayAsync(AuthConfig config)
    {
        var request = new BankTransferChinaPaymentRequest
        {
            OrderId   = Guid.NewGuid().ToString(),
            Amount    = 10000,
            Currency  = "USD",
            ReturnUrl = "http://google.com",
            ClientInfo = new ClientInfoChinaPay()
            {
                Zip = "1",
                City = "1",
                Email = "1",
                Address = "1",
                Country = "1",
                LastName = "1",
                FirstName = "1",
                PhoneNumber = "1"
            }
        };

        var toolzoApi = new ToolzoApi(config);

        await toolzoApi.BankTransferChinaPaymentAsync(request,
                                                      result =>
                                                      {
                                                          //Your success logic here
                                                      },
                                                      error =>
                                                      {
                                                          //Your failed logic here
                                                      });
    }

    public static async Task BankTransferChinaPayoutAsync(AuthConfig config)
    {
        var request = new BankTransferChinaPayoutRequest
        {
            OrderId   = Guid.NewGuid().ToString(),
            Amount    = 10000,
            Currency  = "USD",
            BankCode = "123",
            ClientInfo = new ClientInfoChinaPayout()
            {
                LastName = "XXX",
                FirstName = "AAA"
            },
            RecipientAccount = "SSS"
        };

        var toolzoApi = new ToolzoApi(config);

        await toolzoApi.BankTransferChinaPayoutAsync(request,
                                                     result =>
                                                     {
                                                         //Your success logic here
                                                     },
                                                     error =>
                                                     {
                                                         //Your failed logic here
                                                     });
    }

    #endregion

    #region Boleto

    public static async Task BoletoPaymentAsync(AuthConfig config)
    {
        var request = new BoletoPaymentRequest
        {
            OrderId   = Guid.NewGuid().ToString(),
            Amount    = 10000,
            Currency  = "USD",
            ReturnUrl = "http://google.com",
        };

        var toolzoApi = new ToolzoApi(config);

        await toolzoApi.BoletoPaymentAsync(request,
                                           result =>
                                           {
                                               //Your success logic here
                                           },
                                           error =>
                                           {
                                               //Your failed logic here
                                           });
    }

    public static async Task BoletoPayoutAsync(AuthConfig config)
    {
        var request = new BoletoPayoutRequest
        {
            OrderId   = Guid.NewGuid().ToString(),
            Amount    = 10000,
            Currency  = "USD",
            ReturnUrl = "http://google.com",
        };

        var toolzoApi = new ToolzoApi(config);

        await toolzoApi.BoletoPayoutAsync(request,
                                          result =>
                                          {
                                              //Your success logic here
                                          },
                                          error =>
                                          {
                                              //Your failed logic here
                                          });
    }

    #endregion

    #region Crypto

    public static async Task CryptoPaymentAsync(AuthConfig config)
    {
        var request = new CryptoPaymentRequest
        {
            OrderId   = Guid.NewGuid().ToString(),
            Amount    = 10000,
            Currency  = "USD",
            ReturnUrl = "http://google.com",
        };

        var toolzoApi = new ToolzoApi(config);

        await toolzoApi.CryptoPaymentAsync(request,
                                           result =>
                                           {
                                               //Your success logic here
                                           },
                                           error =>
                                           {
                                               //Your failed logic here
                                           });
    }

    public static async Task CryptoPayoutAsync(AuthConfig config)
    {
        var request = new CryptosPayoutRequest
        {
            OrderId   = Guid.NewGuid().ToString(),
            Amount    = 10000,
            Currency  = "USD",
            ReturnUrl = "http://google.com",
        };

        var toolzoApi = new ToolzoApi(config);

        await toolzoApi.CryptoPayoutAsync(request,
                                          result =>
                                          {
                                              //Your success logic here
                                          },
                                          error =>
                                          {
                                              //Your failed logic here
                                          });
    }

    #endregion

    #region DepositExpress

    public static async Task DepositExpressPaymentAsync(AuthConfig config)
    {
        var request = new DepositExpressPaymentRequest
        {
            OrderId   = Guid.NewGuid().ToString(),
            Amount    = 10000,
            Currency  = "USD",
            ReturnUrl = "http://google.com",
        };

        var toolzoApi = new ToolzoApi(config);

        await toolzoApi.DepositExpressPaymentAsync(request,
                                                   result =>
                                                   {
                                                       //Your success logic here
                                                   },
                                                   error =>
                                                   {
                                                       //Your failed logic here
                                                   });
    }

    #endregion

    #region Lottery

    public static async Task LotteryPaymentAsync(AuthConfig config)
    {
        var request = new LotteryPaymentRequest
        {
            OrderId   = Guid.NewGuid().ToString(),
            Amount    = 10000,
            Currency  = "USD",
            ReturnUrl = "http://google.com",
        };

        var toolzoApi = new ToolzoApi(config);

        await toolzoApi.LotteryPaymentAsync(request,
                                            result =>
                                            {
                                                //Your success logic here
                                            },
                                            error =>
                                            {
                                                //Your failed logic here
                                            });
    }

    #endregion

    #region PicPay

    public static async Task PicPayPaymentAsync(AuthConfig config)
    {
        var request = new PicPayPaymentRequest
        {
            OrderId   = Guid.NewGuid().ToString(),
            Amount    = 10000,
            Currency  = "USD",
            ReturnUrl = "http://google.com",
        };

        var toolzoApi = new ToolzoApi(config);

        await toolzoApi.PicPayPaymentAsync(request,
                                           result =>
                                           {
                                               //Your success logic here
                                           },
                                           error =>
                                           {
                                               //Your failed logic here
                                           });
    }

    #endregion

    #region Pix

    public static async Task PixPaymentAsync(AuthConfig config)
    {
        var request = new PixPaymentRequest
        {
            OrderId   = Guid.NewGuid().ToString(),
            Amount    = 10000,
            Currency  = "USD",
            ReturnUrl = "http://google.com",
        };

        var toolzoApi = new ToolzoApi(config);

        await toolzoApi.PixPaymentAsync(request,
                                        result =>
                                        {
                                            //Your success logic here
                                        },
                                        error =>
                                        {
                                            //Your failed logic here
                                        });
    }

    #endregion

    #region Sepa

    public static async Task SepaPayoutAsync(AuthConfig config)
    {
        var request = new SepaPayoutRequest
        {
            OrderId   = Guid.NewGuid().ToString(),
            Amount    = 10000,
            Currency  = "USD",
            ReturnUrl = "http://google.com",
        };

        var toolzoApi = new ToolzoApi(config);

        await toolzoApi.SepaPayoutAsync(request,
                                        result =>
                                        {
                                            //Your success logic here
                                        },
                                        error =>
                                        {
                                            //Your failed logic here
                                        });
    }

    #endregion

    #region GetOrderState

    public static async Task GetOrderStateAsync(AuthConfig config, string orderId)
    {
        var request = new GetOrderStateRequest
        {
            OrderId = orderId
        };

        var toolzoApi = new ToolzoApi(config);
        await toolzoApi.GetOrderStateAsync(request,
                                           result =>
                                           {
                                               //Your success logic here
                                           },
                                           error =>
                                           {
                                               //Your failed logic here
                                           });
    }

    #endregion
}