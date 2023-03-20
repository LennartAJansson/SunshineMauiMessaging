﻿namespace SunshineMauiMessaging.Messages;

using CommunityToolkit.Mvvm.Messaging.Messages;

using SunshineMauiMessaging.Extensions;

public class ExampleTextChanged : ValueChangedMessage<string>
{
    public ExampleTextChanged(string text) : base(text)
    {
    }
}
