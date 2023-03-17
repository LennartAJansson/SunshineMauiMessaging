namespace SunshineMauiMessaging.Pages;

using SunshineMauiMessaging.ViewModels;

public partial class StartPage : ContentPage
{
    private readonly StartPageViewModel vm;

    public StartPage(StartPageViewModel vm)
    {
        this.vm = vm;
        BindingContext = this.vm;
        InitializeComponent();
    }

}

