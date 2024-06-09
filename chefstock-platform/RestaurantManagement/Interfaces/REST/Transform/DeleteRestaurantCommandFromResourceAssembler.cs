using chefstock_platform.RestaurantManagement.Domain.Model.Commands;
using chefstock_platform.RestaurantManagement.Interfaces.REST.Resources;

namespace chefstock_platform.RestaurantManagement.Interfaces.REST.Transform;

public static class DeleteRestaurantCommandFromResourceAssembler
{
    public static DeleteRestaurantCommand ToCommandFromResource(DeleteRestaurantResource resource)
    {
        return new DeleteRestaurantCommand(resource.Id);
    }
}