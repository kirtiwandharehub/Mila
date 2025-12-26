public class Person : IPrototype
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Relation PersonalRelation { get; set; }
    public Address PersonalAddress { get; set; }

    public IPrototype Clone()
    {
        return (IPrototype) this.MemberwiseClone();
    }
}
