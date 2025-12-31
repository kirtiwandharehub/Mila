public class Tree : ITree
{
    private string type;
    private string color;

    public Tree(string type, string color)
    {
        this.type = type;
        this.color = color;
    }

    public void Draw(int x, int y, int height)
    {
        Console.WriteLine($"Drawing {type} tree of {color} color at {x}, {y} positions with {height} height");
    }
}