public class Business : IPrototype
{
    public string Name { get; set; }
    public Address BusinessAddress { get; set; }

    public Business() {}

    public Business(string name, Address businessAddress)
    {
        Name = name;
        BusinessAddress = businessAddress;
    }

    public Business(Business businessToCopy)
    {
        Name = businessToCopy.Name;
        BusinessAddress = new Address() 
        {
            City = businessToCopy.BusinessAddress.City,
            StreetAddress = businessToCopy.BusinessAddress.StreetAddress,
            PostalCode = businessToCopy.BusinessAddress.PostalCode,
        };
    }

    public IPrototype Clone()
    {
        return new Business(this);
    }
}
