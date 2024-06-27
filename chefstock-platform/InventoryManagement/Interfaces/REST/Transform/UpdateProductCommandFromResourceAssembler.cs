﻿using chefstock_platform.InventoryManagement.Domain.Model.Commands;
using chefstock_platform.InventoryManagement.Interfaces.REST.Resources;

namespace chefstock_platform.InventoryManagement.Interfaces.REST.Transform;

public static class UpdateProductCommandFromResourceAssembler
{
    public static UpdateProductCommand ToCommandFromResource(int productId, UpdateProductResource resource)
    {
        return new UpdateProductCommand(productId,resource.Name, resource.Stock, resource.Image, resource.Description, resource.DueDate, resource.CategoryId);
    }
}