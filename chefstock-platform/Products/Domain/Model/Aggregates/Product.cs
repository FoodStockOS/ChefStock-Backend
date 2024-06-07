using chefstock_platform.Products.Domain.Model.Commands;

namespace chefstock_platform.Products.Domain.Model.Aggregates;

public class Product
{
    public Product()
    {
        // Constructor sin parámetros
    }

    public Product(string? name, int stock, decimal price, DateTime dueDate, ICollection<Inventory>? inventories)
    {
        Name = name;
        Stock = stock;
        Price = price;
        DueDate = dueDate;
        Inventories = inventories;
    }

    public Product(CreateProductCommand command)
    {
        Name = command.Name;
        Stock = command.Stock;
        Price = command.Price;
        DueDate = command.DueDate;
    }
    public void Update(UpdateProductCommand command)
    {
        Name = command.Name;
        Stock = command.Stock;
        Price = command.Price;
        DueDate = command.DueDate;
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public DateTime DueDate { get; set; }
    
    public ICollection<Inventory>? Inventories { get; set; } // Esta es la propiedad de navegación para la relación con la clase Inventory

}