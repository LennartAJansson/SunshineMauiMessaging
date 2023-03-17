namespace SunshineMauiMessaging.Pages;

using SunshineMauiMessaging.ViewModels;

public partial class StartPage : ContentPage
{
    private readonly StartPageViewModel vm;
    private int count = 0;

    public StartPage(StartPageViewModel vm)
    {
        this.vm = vm;
        BindingContext = this.vm;
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        CounterBtn.Text = count == 1 ? $"Clicked {count} time" : $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

