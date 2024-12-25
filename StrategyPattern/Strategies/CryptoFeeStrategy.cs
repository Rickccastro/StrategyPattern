namespace StrategyPattern.Strategies;

public class CryptoFeeStrategy : IPaymentFeeStrategy
{
    public double CalculateFee(double amount) => amount * 0.07;
}
