namespace SunshineMauiMessaging.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

using SunshineMauiMessaging.Extensions;
using SunshineMauiMessaging.Messages;

public partial class StartPageViewModel : ObservableObject
{
    private readonly InitialData initialData;

    [ObservableProperty]
    private string exampleText;

    public StartPageViewModel(InitialData initialData)
    {
        this.initialData = initialData;
        ExampleText = initialData.Text;
    }

    [RelayCommand]
    public Task OkClicked()
    {
        var test = WeakReferenceMessenger.Default.Send(new ExampleTextChanged(ExampleText));
        string text = test.Value;
        return Task.CompletedTask;
    }
}
