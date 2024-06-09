using System.ComponentModel.DataAnnotations;
using chefstock_platform.InventoryManagement.Domain.Model.Commands;
using chefstock_platform.InventoryManagement.Domain.Model.Entities;
using chefstock_platform.UserManagement.Domain.Model.Entities;

namespace chefstock_platform.InventoryManagement.Domain.Model.Aggregates;

public class Product
{
    public Product()
    {

    }

   

    public Product(CreateProductCommand command)
    {
        Name = command.Name;
        Description = command.Description;
        Stock = command.Stock;
        Price = command.Price;
        DueDate = command.DueDate;
        CategoryId = command.CategoryId;
        SupplierId = command.SupplierId;
    }
    public void Update(UpdateProductCommand command)
    {
        ProductId = command.ProductId;
        Name = command.Name;
        Description = command.Description;
        Stock = command.Stock;
        Price = command.Price;
        DueDate = command.DueDate;
        CategoryId = command.CategoryId;
        SupplierId = command.SupplierId;
    }

    public int ProductId { get; set; }
    
    [MaxLength(50)]
    public string? Name { get; set; }

    [MaxLength(200)]
    public string? Description { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public DateTime DueDate { get; set; }
    
    public ICollection<Inventory>? Inventories { get; set; }
    
    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    public int SupplierId { get; set; }
    public Supplier? Supplier { get; set; }
    
    
    public IEnumerable<Transaction>? Transactions { get; set; }
}