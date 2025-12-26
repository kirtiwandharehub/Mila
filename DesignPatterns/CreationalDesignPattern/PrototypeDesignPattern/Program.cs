// Shallow copy
Person parent = new Person()
{
    Name = "John",
    Age = 25,
    PersonalRelation = Relation.Parent,
    PersonalAddress = new Address()
    {
        City = "Seattle",
        StreetAddress = "0000 10th St NE",
        PostalCode = 0,
    }
};
Person child = (Person) parent.Clone();
child.Name = "Bill";
child.Age = 5;
child.PersonalRelation = Relation.Child;

Console.WriteLine("--------- Family info ---------");
Console.WriteLine($"Personal info -> {parent.PersonalRelation} - {parent.Name} - {parent.Age}");
Console.WriteLine($"Address -> {parent.PersonalAddress.StreetAddress} - {parent.PersonalAddress.City} - {parent.PersonalAddress.PostalCode}");
Console.WriteLine($"Personal info -> {child.PersonalRelation} - {child.Name} - {child.Age}");
Console.WriteLine($"Address -> {child.PersonalAddress.StreetAddress} - {child.PersonalAddress.City} - {child.PersonalAddress.PostalCode}");

// Deep copy
Address businessAddress = new Address() { City = "Redmond", StreetAddress = "1 1st St SE", PostalCode = 1 };
Business safeway = new Business("Safeway", businessAddress);
Business starbucks = (Business) safeway.Clone();
starbucks.Name = "Starbucks";
starbucks.BusinessAddress.StreetAddress = "2 1st St SE";

Console.WriteLine("--------- Business info ---------");
Console.WriteLine($"Business info -> {safeway.Name}");
Console.WriteLine($"Address -> {safeway.BusinessAddress.StreetAddress} - {safeway.BusinessAddress.City} - {safeway.BusinessAddress.PostalCode}");
Console.WriteLine($"Business info -> {starbucks.Name}");
Console.WriteLine($"Address -> {starbucks.BusinessAddress.StreetAddress} - {starbucks.BusinessAddress.City} - {starbucks.BusinessAddress.PostalCode}");
