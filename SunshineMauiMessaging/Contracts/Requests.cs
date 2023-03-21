namespace SunshineMauiMessaging.Contracts;

public sealed record RegisterUserRequest(string Email, string FirstName, string LastName, string PhoneNumber, string Password, string ConfirmPassword)
{
    public static RegisterUserRequest Instance(string email, string firstName, string lastName, string phoneNumber, string password, string confirmPassword)
    {
        return new RegisterUserRequest(email, firstName, lastName, phoneNumber, password, confirmPassword);
    }
}

public sealed record RegisterUserRequest2(string Email, string FirstName, string LastName, string PhoneNumber, string Password, string ConfirmPassword, string Url)
{
    public static RegisterUserRequest2 Instance(string email, string firstName, string lastName, string phoneNumber, string password, string confirmPassword, string url)
    {
        return new RegisterUserRequest2(email, firstName, lastName, phoneNumber, password, confirmPassword, url);
    }
}

public sealed record AcknowledgeRegisterUserRequest(string Email, string FirstName, string LastName, string PhoneNumber, string Password, string ConfirmPassword, string Url)
{
    public static AcknowledgeRegisterUserRequest Instance(string email, string firstName, string lastName, string phoneNumber, string password, string confirmPassword, string url)
    {
        return new AcknowledgeRegisterUserRequest(email, firstName, lastName, phoneNumber, password, confirmPassword, url);
    }
}

public sealed record LoginUserRequest(string UserName, string Password)
{
    public static LoginUserRequest Instance(string userName, string password)
    {
        return new LoginUserRequest(userName, password);
    }
}

public sealed record ResetPasswordRequest(string Email, string Password, string ConfirmPassword)
{
    public static ResetPasswordRequest Instance(string email, string password, string confirmPassword)
    {
        return new ResetPasswordRequest(email, password, confirmPassword);
    }
}

public sealed record ResetPasswordRequest2(string Email, string Password, string ConfirmPassword, string Url)
{
    public static ResetPasswordRequest2 Instance(string email, string password, string confirmPassword, string url)
    {
        return new(email, password, confirmPassword, url);
    }
}

public sealed record AcknowledgeResetPasswordRequest(string Email, string Password, string Token)
{
    public static AcknowledgeResetPasswordRequest Instance(string email, string password, string token)
    {
        return new AcknowledgeResetPasswordRequest(email, password, token);
    }
}

public sealed record GetUsersRequest()
{
    public static GetUsersRequest Instance()
    {
        return new();
    }
}

public sealed record GetUserRequest(string UserName)
{
    public static GetUserRequest Instance(string userName)
    {
        return new(userName);
    }
}

public sealed record UpdateUserRequest(Guid Id, string UserName, string FirstName, string LastName, string Email, string PhoneNumber)
{
    public static UpdateUserRequest Instance(Guid id, string userName, string firstName, string lastName, string email, string phoneNumber)
    {
        return new(id, userName, firstName, lastName, email, phoneNumber);
    }
}

public sealed record DeleteUserRequest(string UserName)
{
    public static DeleteUserRequest Instance(string userName)
    {
        return new(userName);
    }
}

public sealed record CreateRoleRequest(string Name)
{
    public static CreateRoleRequest Instance(string name)
    {
        return new CreateRoleRequest(name);
    }
}

public sealed record GetRolesRequest()
{
    public static GetRolesRequest Instance()
    {
        return new();
    }

}

public sealed record AddUserToRoleRequest(string UserName, string Role)
{
    public static AddUserToRoleRequest Instance(string userName, string role)
    {
        return new(userName, role);
    }
}
