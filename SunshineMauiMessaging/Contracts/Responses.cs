namespace SunshineMauiMessaging.Contracts;
using System;
using System.Collections.Generic;

public sealed record AcknowledgeRegisterUserResponse(Guid Id, string? UserName)
{
    public static AcknowledgeRegisterUserResponse Instance(Guid id, string? userName)
    {
        return new AcknowledgeRegisterUserResponse(id, userName);
    }
}

public sealed record LoginUserResponse(string Token, Guid IdentityId, string? Username, IEnumerable<string> Roles)
{
    public static LoginUserResponse Instance(string jwt, Guid id, string? userName, IEnumerable<string> roles)
    {
        return new LoginUserResponse(jwt, id, userName, roles);
    }
}

public sealed record ResetPasswordResponse(Guid Id, string? Url, string? Encoded)
{
    public static ResetPasswordResponse Instance(Guid id, string? url, string? encoded)
    {
        return new ResetPasswordResponse(id, url, encoded);
    }
}

public sealed record AcknowledgeResetPasswordResponse(Guid Id, string? UserName)
{
    public static AcknowledgeResetPasswordResponse Instance(Guid id, string? userName)
    {
        return new AcknowledgeResetPasswordResponse(id, userName);
    }
}

public sealed record UserResponse(Guid Id, string? UserName, string? Email, string? FirstName, string? LastName, string? PhoneNumber)
{
    public static UserResponse Instance(Guid id, string? userName, string? email, string? firstName, string? lastName, string? phoneNumber)
    {
        return new UserResponse(id, userName, email, firstName, lastName, phoneNumber);
    }
}

public sealed record UserFullResponse(Guid Id, string? UserName, string? Email, string? FirstName, string? LastName, string? PhoneNumber, IEnumerable<string> Roles)
{
    public static UserFullResponse Instance(Guid id, string? userName, string? email, string? firstName, string? lastName, string? phoneNumber, IEnumerable<string> roles)
    {
        return new UserFullResponse(id, userName, email, firstName, lastName, phoneNumber, roles);
    }
}

public sealed record RoleResponse(Guid RoleId, string? Role)
{
    public static RoleResponse Instance(Guid roleId, string? role)
    {
        return new RoleResponse(roleId, role);
    }
}

public sealed record AddUserToRoleResponse(string? UserName, string Role)
{
    public static AddUserToRoleResponse Instance(string? userName, string role)
    {
        return new AddUserToRoleResponse(userName, role);
    }
}

