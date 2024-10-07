namespace EFCoreRelation.Entity;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}

public class Product
{
    public int Id { get; set; }
    public double Price { get; set; }
    public int CategoryId { get; set; }
}