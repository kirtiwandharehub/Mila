public class Worker
{
    private readonly IAppInfo appInfo;
    private readonly IRequestTracker requestTracker;
    private readonly IOperationService operationService;

    public Worker(IAppInfo appInfo, IRequestTracker requestTracker, IOperationService operationService)
    {
        this.appInfo = appInfo;
        this.requestTracker = requestTracker;
        this.operationService = operationService;
    }

    public void Run()
    {
        Console.WriteLine($"AppInfo: {appInfo.Id}");
        Console.WriteLine($"RequestTracker: {requestTracker.Id}");
        Console.WriteLine($"OperationService: {operationService.Id}");
    }
}