public class RequestTracker : IRequestTracker
{
    public Guid Id { get; } = Guid.NewGuid();
}