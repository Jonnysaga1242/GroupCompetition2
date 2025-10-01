namespace USFLibrary;

public abstract class Person
{
    public string Name { get; }
    public string Email { get; }
    public string ID { get; }   // StudentID or StaffID

    protected Person(string name, string email, string id)
    {
        Name = name;
        Email = email;
        ID = id;
    }

    public override string ToString() => $"Name: {Name}, ID: {ID}";
}
