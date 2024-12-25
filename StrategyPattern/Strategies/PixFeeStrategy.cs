namespace StrategyPattern.Strategies;

public class PixFeeStrategy : IPaymentFeeStrategy
{
    public double CalculateFee(double amount) => 1.00;

}
