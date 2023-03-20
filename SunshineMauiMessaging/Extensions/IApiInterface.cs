namespace SunshineMauiMessaging.Extensions;

public interface IApiInterface
{
    public Task LoginUser();
    public Task LogoutUser();
    public Task RefreshUser();
}
public class ApiInterface : IApiInterface
{
    public Task LoginUser()
    {
        throw new NotImplementedException();
    }

    public Task LogoutUser()
    {
        throw new NotImplementedException();
    }

    public Task RefreshUser()
    {
        throw new NotImplementedException();
    }
}