namespace SunshineMauiMessaging.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

using SunshineMauiMessaging.Extensions;
using SunshineMauiMessaging.Messages;

public partial class ActivitiesPageViewModel : ObservableRecipient
{
    [ObservableProperty]
    private string exampleText;

    private readonly InitialData initialData;

    public ActivitiesPageViewModel(InitialData initialData)
    {
        this.initialData = initialData;
        ExampleText = initialData.ExampleText;
        WeakReferenceMessenger.Default.Register<ExampleTextChanged>(this, HandleOpenWindowMessage);
    }

    private void HandleOpenWindowMessage(object recipient, ExampleTextChanged message)
    {
        ExampleText = message.Value;
    }

    [RelayCommand]
    public Task OkClicked()
    {
        initialData.ExampleText = ExampleText;
        return Task.CompletedTask;
    }
}
