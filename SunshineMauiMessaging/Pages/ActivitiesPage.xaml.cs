namespace SunshineMauiMessaging.Pages;

using SunshineMauiMessaging.ViewModels;

public partial class ActivitiesPage : ContentPage
{
    private readonly ActivitiesPageViewModel vm;

    public ActivitiesPage(ActivitiesPageViewModel vm)
    {
        this.vm = vm;
        BindingContext = this.vm;
        InitializeComponent();
    }
}