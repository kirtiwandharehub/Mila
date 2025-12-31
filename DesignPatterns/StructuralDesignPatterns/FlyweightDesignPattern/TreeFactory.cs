using System.Collections.Concurrent;
using System.ComponentModel.Design;

public class TreeFactory
{
    private static ConcurrentDictionary<string, ITree> trees = new();

    public static ITree GetTree(string type)
    {
        return trees.GetOrAdd(type, t => CreateTree(t));
    }

    private static ITree CreateTree(string type)
    {
        ITree tree = null;
        switch(type)
        {
            case "oak": 
                tree = new Tree(type, "Green"); 
                Console.WriteLine($"Created {type} tree");
                break;
            case "pine":
                tree = new Tree(type, "DarkGreen");  
                Console.WriteLine($"Created {type} tree");
                break;
            default: 
                throw new ArgumentException("Invalid type");
        }

        return tree;
    }
}