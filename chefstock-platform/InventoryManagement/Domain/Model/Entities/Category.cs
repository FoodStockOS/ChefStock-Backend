using System.ComponentModel.DataAnnotations;
using chefstock_platform.InventoryManagement.Domain.Model.Aggregates;

namespace chefstock_platform.InventoryManagement.Domain.Model.Entities;

public class Category
{
    public int Id { get; set; }

    [MaxLength(50)]
    public string? CategoryName { get; set; }

    public ICollection<Product>? Products { get; set; }
}