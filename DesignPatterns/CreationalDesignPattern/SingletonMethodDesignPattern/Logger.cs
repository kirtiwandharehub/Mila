using System.Text;

public sealed class Logger
{
    private static Logger instance;
    private static readonly object lockObject = new();

    private Logger() {}

    public static Logger GetInstance
    {
        get
        {
            lock (lockObject)
            {
                if (instance is null)
                {
                    Console.WriteLine("Logger is initialized.");
                    instance = new();
                }
                return instance;
            }
        }
    }

    public void Log(string message, params object[] args)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(message);
        foreach(object arg in args)
        {
            sb.Append($"{arg.ToString()}");
        }

        Console.WriteLine(sb.ToString());
    }
}