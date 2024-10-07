namespace EFCoreRelation.Entity;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}

public class StudentBook
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int BookId { get; set; }
}

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}