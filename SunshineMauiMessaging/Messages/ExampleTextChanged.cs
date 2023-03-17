namespace SunshineMauiMessaging.Messages;

using CommunityToolkit.Mvvm.Messaging.Messages;

public class ExampleTextChanged : ValueChangedMessage<string>
{
    public ExampleTextChanged(string text) : base(text)
    {
    }
}
