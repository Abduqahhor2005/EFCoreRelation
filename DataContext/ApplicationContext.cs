using EFCoreRelation.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRelation.DataContext;

public class ApplicationContext:DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Type { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<StudentBook> StudentBooks { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options){}
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        // one to one
        builder.Entity<Category>().HasOne<Product>().WithOne().IsRequired().
            OnDelete(DeleteBehavior.Cascade);
        builder.Entity<Product>().HasAlternateKey(x => x.CategoryId);
        
        // one to many
        builder.Entity<Company>().HasMany<Employee>().WithOne().IsRequired();
        
        // many to many 
        builder.Entity<Student>().HasMany<StudentBook>().WithOne().IsRequired();
        builder.Entity<Book>().HasMany<StudentBook>().WithOne().IsRequired();
        base.OnModelCreating(builder);
    }
}