namespace USFLibrary;

public sealed class Staff : Person
{
    public string Position { get; }
    public string Department { get; }

    public Staff(string name, string email, string id, string position, string department)
        : base(name, email, id)
    {
        Position = position;
        Department = department;
    }
}
