namespace SunshineMauiMessaging.Extensions;

using CommunityToolkit.Mvvm.Messaging;

using SunshineMauiMessaging.Clients;
using SunshineMauiMessaging.Contracts;
using SunshineMauiMessaging.Messages;

public class CurrentUser
{
    public Guid IdentityId { get; set; } = Guid.Empty;
    public string UserName { get => userName; set { userName = value; ValueChanged(this); } }
    private string userName = string.Empty;
    public string Password { get => password; set { password = value; ValueChanged(this); } }
    private string password = string.Empty;
    public string JwtToken { get => jwtToken; set { jwtToken = value; ValueChanged(this); } }
    private string jwtToken = string.Empty;

    private LoginUserResponse? user = null;

    private readonly IAuthIdentityClient api;

    public CurrentUser(IAuthIdentityClient api)
    {
        this.api = api;
    }

    public async Task LoginUser()
    {
        user = await api.LoginUser(LoginUserRequest.Instance("", ""));
        IdentityId = user.IdentityId;
        UserName = user.Username!;
        JwtToken = user.Token;
    }
    public Task LogoutUser()
    {
        throw new NotImplementedException();
    }

    public Task RefreshUser()
    {
        throw new NotImplementedException();
    }

    public void ValueChanged(CurrentUser user)
    {
        WeakReferenceMessenger.Default.Send(new UserChanged(user));
    }
}