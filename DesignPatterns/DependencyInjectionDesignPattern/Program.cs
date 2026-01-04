using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new ServiceCollection();

services.AddSingleton<IAppInfo, AppInfo>();
services.AddScoped<IRequestTracker, RequestTracker>();
services.AddTransient<IOperationService, OperationService>();
services.AddTransient<Worker>();

IServiceProvider serviceProvider = services.BuildServiceProvider();

using (IServiceScope scope = serviceProvider.CreateScope())
{
    Console.WriteLine("----------First Scope----------");

    Worker worker1 = scope.ServiceProvider.GetRequiredService<Worker>();
    Worker worker2 = scope.ServiceProvider.GetRequiredService<Worker>();

    worker1.Run();
    Console.WriteLine();
    worker2.Run();
}

Console.WriteLine();

using (IServiceScope scope = serviceProvider.CreateScope())
{
    Console.WriteLine("----------Second Scope----------");
    
    Worker worker = scope.ServiceProvider.GetRequiredService<Worker>();

    worker.Run();
}