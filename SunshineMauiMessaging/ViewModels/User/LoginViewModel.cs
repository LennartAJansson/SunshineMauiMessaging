namespace KlassikerApp.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    private string email;
    [ObservableProperty]
    private string password;

    public LoginViewModel(/*Inject service to api*/)
    {
    }


    [RelayCommand]
    private void Login()
    {
        //Create a LoginUserRequest?
        //Mediator for LoginViewModel?
        //throw new NotImplementedException();
    }
}
