namespace KlassikerApp.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KlassikerApp.Models;

public partial class RegisterViewModel : ObservableObject
{
    [ObservableProperty]
    private string email;
    [ObservableProperty]
    private string password;
    [ObservableProperty]
    private string confirmPassword;
    [ObservableProperty]
    private string firstname;
    [ObservableProperty]
    private string lastname;
    [ObservableProperty]
    private string phoneNumber;

    [ObservableProperty]
    private Office[] offices = new Office[] {
        new Office { OfficeId = 1, Name = "Berlin" },
        new Office { OfficeId = 2, Name = "Hamburg" },
        new Office{OfficeId = 3, Name = "München" } };

    [ObservableProperty]
    private Office selectedOffice;

    public RegisterViewModel(/*Inject service to api*/)
    {
    }

    [RelayCommand]
    private Task Register()
    {
        //Create a AccountCreateRequest or RegisterUserRequest?
        //Mediator for RegisterViewModel?
        //throw new NotImplementedException();
        return Task.CompletedTask;
    }
}
