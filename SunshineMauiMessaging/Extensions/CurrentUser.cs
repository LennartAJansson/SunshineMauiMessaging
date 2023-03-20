namespace SunshineMauiMessaging.Extensions;

using CommunityToolkit.Mvvm.Messaging;

using SunshineMauiMessaging.Messages;

public class CurrentUser
{
    public string UserName { get => userName; set { userName = value; ValueChanged(this); } }
    private string userName = "Initial Text";
    public Guid Id { get; set; } = Guid.Empty;
    public string JwtToken { get => jwtToken; set { jwtToken = value; ValueChanged(this); } }
    private string jwtToken = string.Empty;

    private readonly IApiInterface api;

    public CurrentUser(IApiInterface api)
    {
        this.api = api;
    }

    public async Task LoginUser()
    {
        await api.LoginUser();
    }
    public async Task LogoutUser()
    {
        await api.LogoutUser();
    }

    public async Task RefreshUser()
    {
        await api.RefreshUser();
    }

    public void ValueChanged(CurrentUser user)
    {
        WeakReferenceMessenger.Default.Send(new UserChanged(user));
    }
}