namespace SunshineMauiMessaging.Extensions;

using System;

using CommunityToolkit.Mvvm.Messaging;

using SunshineMauiMessaging.Messages;

public class InitialData
{
    public string Text { get; set; } = "Initial Text";

    public InitialData()
    {
        WeakReferenceMessenger.Default.Register<ExampleTextChanged>(this, HandleOpenWindowMessage);
    }

    private void HandleOpenWindowMessage(object recipient, ExampleTextChanged message)
    {
        Text=message.Value;
    }
}