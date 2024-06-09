using System.ComponentModel.DataAnnotations;
using chefstock_platform.InventoryManagement.Domain.Model.Commands;
using chefstock_platform.InventoryManagement.Domain.Model.Entities;

namespace chefstock_platform.InventoryManagement.Domain.Model.Aggregates;

public class Product
{
    public Product()
    {

    }

    public Product(string? name, string? description, int stock, decimal price, DateTime dueDate, int categoryId, int supplierId, ICollection<Inventory>? inventories)
    {
        Name = name;
        Description = description;
        Stock = stock;
        Price = price;
        DueDate = dueDate;
        CategoryId = categoryId;
        SupplierId = supplierId;
        Inventories = inventories ?? new HashSet<Inventory>();
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
        Name = command.Name;
        Description = command.Description;
        Stock = command.Stock;
        Price = command.Price;
        DueDate = command.DueDate;
        CategoryId = command.CategoryId;
        SupplierId = command.SupplierId;
    }

    public int Id { get; set; }
    
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

}