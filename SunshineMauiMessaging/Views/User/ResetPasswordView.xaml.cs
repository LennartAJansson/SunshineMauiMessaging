namespace KlassikerApp.Views;

using KlassikerApp.ViewModels;

public partial class ResetPasswordView : ContentView
{
	private ResetPasswordViewModel viewModel;

	public ResetPasswordView(ResetPasswordViewModel viewModel)
	{
		this.viewModel = viewModel;
		BindingContext = this.viewModel;

		InitializeComponent();
	}
}