namespace SunshineMauiMessaging.Messages;

using CommunityToolkit.Mvvm.Messaging.Messages;

using SunshineMauiMessaging.Extensions;

public class UserChanged : ValueChangedMessage<CurrentUser>
{
    public UserChanged(CurrentUser value) : base(value)
    {
    }
}