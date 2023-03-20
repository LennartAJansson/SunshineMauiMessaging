namespace SunshineMauiMessaging.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

using SunshineMauiMessaging.Extensions;
using SunshineMauiMessaging.Messages;

public partial class StartPageViewModel : ObservableRecipient
{
    private readonly InitialData initialData;
    private readonly CurrentUser user;
    [ObservableProperty]
    private string exampleText;

    public StartPageViewModel(InitialData initialData, CurrentUser user)
    {
        this.initialData = initialData;
        this.user = user;
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
