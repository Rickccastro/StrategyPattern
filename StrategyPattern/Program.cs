using StrategyPattern.Strategies;

namespace StrategyPattern;

internal class Program
{
    static void Main(string[] args)
    {
        var paymentProcessor = new PaymentProcessor();

        double amount = 1000.0;

        Console.WriteLine($"Credit Card Fee: {paymentProcessor.CalculateFee("CreditCard", amount)}");
        Console.WriteLine($"Bank Slip Fee: {paymentProcessor.CalculateFee("BankSlip", amount)}");
        Console.WriteLine($"PayPal Fee: {paymentProcessor.CalculateFee("PayPal", amount)}");
        Console.WriteLine($"PIX Fee: {paymentProcessor.CalculateFee("PIX", amount)}");
        Console.WriteLine($"Crypto Fee: {paymentProcessor.CalculateFee("Crypto", amount)}");

        /*Strategy Pattern*/

        var paymentProcessorStrategy = new PaymentProcessorContext();

        paymentProcessorStrategy.SetStrategy(new BankSlipFeeStrategy());
        paymentProcessorStrategy.CalculateFee(amount);

        paymentProcessorStrategy.SetStrategy(new CreditCardFeeStrategy());
        paymentProcessorStrategy.CalculateFee(amount);

        paymentProcessorStrategy.SetStrategy(new CryptoFeeStrategy());
        paymentProcessorStrategy.CalculateFee(amount);
        
        paymentProcessorStrategy.SetStrategy(new PixFeeStrategy());
        paymentProcessorStrategy.CalculateFee(amount); 

        paymentProcessorStrategy.SetStrategy(new PayPalFeeStrategy());
        paymentProcessorStrategy.CalculateFee(amount);  

    }
}
