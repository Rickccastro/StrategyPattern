namespace StrategyPattern;
public interface IPaymentFeeStrategy
{
    double CalculateFee(double amount);
}
