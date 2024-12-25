namespace StrategyPattern;

public class PaymentProcessor
{
    public double CalculateFee(string paymentMethod, double amount)
    {
        if (paymentMethod.Equals("CreditCard", StringComparison.OrdinalIgnoreCase))
        {
            return amount * 0.05;
        }
        else if (paymentMethod.Equals("BankSlip", StringComparison.OrdinalIgnoreCase))
        {
            return amount * 0.02;
        }
        else if (paymentMethod.Equals("PayPal", StringComparison.OrdinalIgnoreCase))
        {
            return amount * 0.04;
        }
        else if (paymentMethod.Equals("PIX", StringComparison.OrdinalIgnoreCase))
        {
            return 1.00;
        }
        else if (paymentMethod.Equals("Crypto", StringComparison.OrdinalIgnoreCase))
        {
            return amount * 0.07;
        }
        else
        {
            throw new InvalidOperationException($"Unsupported payment method: {paymentMethod}");
        }
    }
}
