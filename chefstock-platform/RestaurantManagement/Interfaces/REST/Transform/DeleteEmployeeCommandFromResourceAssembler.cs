using chefstock_platform.RestaurantManagement.Domain.Model.Commands;
using chefstock_platform.RestaurantManagement.Interfaces.REST.Resources;

namespace chefstock_platform.RestaurantManagement.Interfaces.REST.Transform;

public static class DeleteEmployeeCommandFromResourceAssembler
{
    public static DeleteEmployeeCommand ToCommandFromResource(DeleteEmployeeResource resource)
    {
        return new DeleteEmployeeCommand(resource.Id);
    }
}