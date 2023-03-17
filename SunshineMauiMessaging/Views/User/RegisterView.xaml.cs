namespace KlassikerApp.Views;

using KlassikerApp.ViewModels;

public partial class RegisterView : ContentView
{
    private RegisterViewModel viewModel;
    public RegisterView(RegisterViewModel viewModel)
    {
        this.viewModel = viewModel;
        BindingContext = this.viewModel;

        InitializeComponent();
    }
}