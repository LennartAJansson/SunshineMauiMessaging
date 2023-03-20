namespace SunshineMauiMessaging.Extensions;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;

using SunshineMauiMessaging.Messages;

public class InitialData
{
    public string ExampleText { get=>exampleText; set { exampleText = value; ValueChanged(exampleText); } } 
    private string exampleText = "Initial Text";

    public InitialData()
    {
    }

    public void ValueChanged(string text)
    {
        WeakReferenceMessenger.Default.Send(new ExampleTextChanged(text));
    }
}
