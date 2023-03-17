namespace SunshineMauiMessaging;

public partial class App : Application
{
    private readonly AppShell shell;

    public App(AppShell shell)
    {
        InitializeComponent();
        this.shell = shell;
        MainPage = this.shell;
    }
}
