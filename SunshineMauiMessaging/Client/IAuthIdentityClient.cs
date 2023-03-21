namespace SunshineMauiMessaging.Clients;

using Refit;

using SunshineMauiMessaging.Contracts;

public interface IAuthIdentityClient
{
    [Post("/auth/RegisterUser")]
    Task<UserFullResponse> RegisterUser(RegisterUserRequest request);

    [Post("/auth/LoginUser")]
    Task<LoginUserResponse> LoginUser(LoginUserRequest request);

    [Post("/auth/ResetPassword")]
    Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest request);

    [Post("/auth/AcknowledgeResetPassword/{encoded}")]
    Task<AcknowledgeResetPasswordResponse> AcknowledgeResetPassword(string encoded);

    [Get("/auth/GetMyInfo")]
    [Headers("Authorization: Bearer")]
    Task<UserFullResponse> GetMyInfo();

    [Get("/auth/GetUsers")]
    [Headers("Authorization: Bearer")]
    Task<IEnumerable<UserFullResponse>> GetUsers(GetUsersRequest request);

    [Get("/auth/GetUser/{name}")]
    [Headers("Authorization: Bearer")]
    Task<UserFullResponse> GetUserByName(string name);

    [Post("/auth/UpdateUser")]
    [Headers("Authorization: Bearer")]
    Task<UserFullResponse> UpdateUser(UpdateUserRequest request);

    [Delete("/auth/DeleteUser/{name}")]
    [Headers("Authorization: Bearer")]
    Task<UserFullResponse> DeleteUser(string name);


    [Post("/auth/CreateRole")]
    [Headers("Authorization: Bearer")]
    Task<RoleResponse> CreateRole(CreateRoleRequest request);

    [Get("/auth/GetRoles")]
    [Headers("Authorization: Bearer")]
    Task<IEnumerable<string>> GetRoles();

    [Post("/auth/AddUserToRole")]
    [Headers("Authorization: Bearer")]
    Task<UserFullResponse> AddUserToRole(AddUserToRoleRequest request);
}
