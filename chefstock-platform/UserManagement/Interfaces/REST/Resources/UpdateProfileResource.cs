﻿namespace chefstock_platform.UserManagement.Interfaces.REST.Resources;

public record UpdateProfileResource(int ProfileId, int UserId, string Bio, string ProfilePicture);