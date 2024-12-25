namespace StrategyPattern.Strategies;

public class PayPalFeeStrategy : IPaymentFeeStrategy
{
    public double CalculateFee(double amount) => amount * 0.04;

}
