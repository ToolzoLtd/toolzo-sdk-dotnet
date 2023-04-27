namespace ToolzoApiImplementations.DTO.Infrastructure;

public class MessageTypes
{
    public const string Request               = "Request";
    public const string RequestWithCryptogram = "RequestWithCryptogram";
    public const string Response              = "Response";
    public const string Error                 = "Error";
}

public class PaymentMethods
{
    public class Cards
    {
        public const string Payment  = "Cards.Payment";
        public const string Payout   = "Cards.Payout";
        public const string Rebill   = "Cards.Rebill";
        public const string Refund   = "Cards.Refund";
        public const string Reversal = "Cards.Reversal";
    }

    public class BankTransfer
    {
        public const string EuPayment    = "BankTransferEu.Pay";
        public const string ChinaPay = "BankTransferChina.Pay";
        public const string ChinaPayout  = "BankTransferChina.Payout";
    }

    public class Boleto
    {
        public const string Payment = "Boleto.Payment";
        public const string Payout  = "Boleto.Payout";
    }

    public class Crypto
    {
        public const string Payment = "Crypto.Payment";
        public const string Payout  = "Crypto.Payout";
    }

    public class DepositExpress
    {
        public const string Payment = "DepositExpress.Payment";
    }

    public class Lottery
    {
        public const string Payment = "Lottery.Payment";
    }

    public class PicPay
    {
        public const string Payment = "PicPay.Payment";
    }

    public class Pix
    {
        public const string Payment = "Pix.Payment";
    }

    public class Sepa
    {
        public const string Payment = "Sepa.Payment";
    }

    public const string GetOrderState = "GetOrderState";
}