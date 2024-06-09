using System.ComponentModel.DataAnnotations;
using chefstock_platform.InventoryManagement.Domain.Model.Aggregates;

namespace chefstock_platform.InventoryManagement.Domain.Model.Entities;

public class Supplier
{
    public int Id { get; set; }

    [MaxLength(50)]
    public string? SupplierName { get; set; }

    [MaxLength(50)]
    public string? ContactName { get; set; }

    [MaxLength(100)]
    public string? ContactEmail { get; set; }

    [MaxLength(15)]
    public string? Phone { get; set; }

    [MaxLength(100)]
    public string? Address { get; set; }

    public ICollection<Product?>? Products { get; set; }
}