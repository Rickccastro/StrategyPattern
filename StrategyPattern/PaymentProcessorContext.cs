namespace StrategyPattern;

public class PaymentProcessorContext
{
    private IPaymentFeeStrategy _strategy;

    public void SetStrategy(IPaymentFeeStrategy strategy)
    {
        _strategy = strategy;
    }

    public double CalculateFee(double amount)
    {
        if (_strategy == null)
          throw new InvalidOperationException("Strategy not set");

        return _strategy.CalculateFee(amount);
    }
}
