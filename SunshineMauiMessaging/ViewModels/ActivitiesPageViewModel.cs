namespace SunshineMauiMessaging.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

using SunshineMauiMessaging.Extensions;
using SunshineMauiMessaging.Messages;

public partial class ActivitiesPageViewModel : ObservableRecipient
{
    private readonly CurrentUser user;

    [ObservableProperty]
    private string userName = string.Empty;

    public ActivitiesPageViewModel(CurrentUser user)
    {
        this.user = user;
        WeakReferenceMessenger.Default.Register<UserChanged>(this, HandleOpenWindowMessage);
    }

    private void HandleOpenWindowMessage(object recipient, UserChanged message)
    {
        UserName = message.Value.UserName;
    }

    [RelayCommand]
    public Task OkClicked()
    {
        return Task.CompletedTask;
    }
}
