using System.Reflection.Metadata.Ecma335;

public class TokenBucket
{
    private readonly int capacity;
    private readonly double refillRatePerSecond;
    private double tokens;
    private DateTime lastRefillDateTime;

    private readonly object lockObject = new object();

    public TokenBucket(int capacity, double refillRatePerSecond)
    {
        this.capacity = capacity;
        this.refillRatePerSecond = refillRatePerSecond;
        tokens  = capacity;
        lastRefillDateTime = DateTime.UtcNow;        
    }

    public bool AllowRequest()
    {
        lock(lockObject)
        {
            Refill();

            if (tokens >= 1)
            {
                tokens -= 1;
                return true;
            }
            return false;
        }
    }

    private void Refill()
    {
        DateTime currentDateTime = DateTime.UtcNow;
        double elapsedSeconds = (currentDateTime - lastRefillDateTime).TotalSeconds;

        if (elapsedSeconds <= 0)
            return;

        tokens = Math.Min(capacity, tokens + (refillRatePerSecond * elapsedSeconds));
        lastRefillDateTime = currentDateTime;
    }
}