namespace KlassikerApp.Views;

using KlassikerApp.ViewModels;

public partial class LoginView : ContentView
{
	private readonly LoginViewModel viewModel;

	public LoginView(LoginViewModel viewModel)
	{
		this.viewModel = viewModel;
		BindingContext = this.viewModel;

		InitializeComponent();
	}
}