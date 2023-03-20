namespace SunshineMauiMessaging.Extensions;

public interface IApiInterface
{
    public Task LoginUser();
    public Task LogoutUser();
    public Task RefreshUser();
}
