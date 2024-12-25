namespace StrategyPattern.Strategies;

public class BankSlipFeeStrategy : IPaymentFeeStrategy
{
    public double CalculateFee(double amount) => amount * 0.02;
}
