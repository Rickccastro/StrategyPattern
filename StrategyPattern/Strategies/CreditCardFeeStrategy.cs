namespace StrategyPattern.Strategies;

public class CreditCardFeeStrategy : IPaymentFeeStrategy
{
    public double CalculateFee(double amount) => amount * 0.05;
}
