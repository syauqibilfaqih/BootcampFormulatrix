using System.Data.Common;
namespace EFCoreSample;
using Microsoft.EntityFrameworkCore;

public class MyDatabase : DbContext
{
    public DbSet<Category> Category { get; set; }
    public string DbPath { get; }

    public MyDatabase()
    {
        //var folder = "EFCoreSample";
        var path = "D:\\Practices\\CSharp\\FromGithub\\BootcampFormulatrix\\Day27\\EFCoreSample";//Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "MyDatabase.db");
    }
 
    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<Category>(category =>
		{
			category.HasKey(c => c.CategoryId);
			category.Property(c => c.CategoryName).IsRequired().HasMaxLength(20);
			category.Property(c => c.Description).HasMaxLength(100);
			category.HasMany(c => c.Products);
		});
		model.Entity<Product>(product =>
		{
			product.HasKey(p => p.ProductId);
			product.Property(p => p.ProductName).IsRequired().HasMaxLength(20);
			product.HasOne(p => p.Category);
			product.Property(p => p.Cost).HasColumnName("ProductPrice").HasColumnType("money");
		});
		//Seeding
		model.Entity<Category>().HasData(
			new Category() 
			{
				CategoryId = 1,
				CategoryName = "Electronic",
				Description = "Ini Electronic"
			},
			new Category() 
			{
				CategoryId = 2,
				CategoryName = "Fruit",
				Description = "Ini Fruit"
			},
            new Category() 
			{
				CategoryId = 3,
				CategoryName = "Vegetable",
				Description = "Ini Vegetable"
			}
		);
		model.Entity<Product>().HasData(
			new Product() 
			{
				ProductId = 1,
				ProductName = "TV",
				CategoryId = 1
			},
			new Product() 
			{
				ProductId = 2,
				ProductName = "Radio",
				CategoryId = 1
			}
		);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"FileName={DbPath}");
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {   
    //     // optionsBuilder.UseNpgsql(@"Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
    //     if(Category.Count() == 0) 
    //     {
    //         SeedData(this);
    //     }
    // }
    // private void SeedData(MyDatabase myDatabase) 
    // {
    //     myDatabase.Category.Add(new Category() { CategoryId = 1, CategoryName = "Electronic" });
    //     myDatabase.SaveChanges();
    // }
}
