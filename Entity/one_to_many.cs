namespace EFCoreRelation.Entity;

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}