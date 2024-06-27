﻿using System.Net.Mime;
using chefstock_platform.InventoryManagement.Domain.Model.Commands;
using chefstock_platform.InventoryManagement.Domain.Model.Queries;
using chefstock_platform.InventoryManagement.Domain.Services;
using chefstock_platform.InventoryManagement.Interfaces.REST.Resources;
using chefstock_platform.InventoryManagement.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace chefstock_platform.InventoryManagement.Interfaces.REST;


[ApiController]
[Route("api/v1/[controller]")]
[EnableCors("AllowAll")]
[Produces(MediaTypeNames.Application.Json)]
public class ProductsController(IProductCommandService productCommandService, IProductQueryService productQueryService)
    : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateProduct(CreateProductResource resource)
    {
        var createProductCommand = CreateProductCommandFromResourceAssembler.ToCommandFromResource(resource);
        var product = await productCommandService.Handle(createProductCommand);
        if (product is null) return BadRequest();
        var productResource = ProductResourceFromEntityAssembler.ToResourceFromEntity(product);
        return CreatedAtAction(nameof(GetProductById), new {productId = productResource.ProductId}, productResource);
    }
    [HttpPut("{productId:int}")]
    public async Task<IActionResult> UpdateProduct(int productId, UpdateProductResource resource)
    {
        var updateProductCommand = UpdateProductCommandFromResourceAssembler.ToCommandFromResource(productId,resource);
        var updatedProduct = await productCommandService.Handle(updateProductCommand);
        if (updatedProduct is null) return BadRequest();
        var productResource = ProductResourceFromEntityAssembler.ToResourceFromEntity(updatedProduct);
        return Ok(productResource);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var getAllProductsQuery = new GetAllProductsQuery();
        var products = await productQueryService.Handle(getAllProductsQuery);
        var productResources = products.Select(ProductResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(productResources);
    }

    [HttpGet("{productId:int}")]
    public async Task<IActionResult> GetProductById(int productId)
    {
        var getProductByIdQuery = new GetProductByIdQuery(productId);
        var product = await productQueryService.Handle(getProductByIdQuery);
        if (product == null) return NotFound();
        var productResource = ProductResourceFromEntityAssembler.ToResourceFromEntity(product);
        return Ok(productResource);
    }

    

    [HttpDelete("{productId:int}")]
    public async Task<IActionResult> DeleteProduct(int productId)
    {
        var deleteProductCommand = new DeleteProductCommand(productId);
        await productCommandService.Handle(deleteProductCommand);
        return NoContent();
    }
}