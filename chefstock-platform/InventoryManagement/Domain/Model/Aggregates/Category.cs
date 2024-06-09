using System.ComponentModel.DataAnnotations;

namespace chefstock_platform.InventoryManagement.Domain.Model.Aggregates;

public class Category
{
    public int CategoryId { get; set; }

    [MaxLength(50)]
    public string? CategoryName { get; set; }

    public IEnumerable<Product>? Products { get; }

    //public ICollection<Product>? Products { get; set; }
}