using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace KlassikerApp.ViewModels;



public partial class ResetPasswordViewModel : ObservableObject
{
    [ObservableProperty]
    private string email;
    [ObservableProperty]
    private string password;
    [ObservableProperty]
    private string confirmPassword;

    public ResetPasswordViewModel(/*Inject service to api*/)
    {
    }

    [RelayCommand]
    private void ResetPassword()
    {
        //Create a ResetPasswordRequest?
        //Mediator for ResetPasswordViewModel?
        //throw new NotImplementedException();
    }
}
