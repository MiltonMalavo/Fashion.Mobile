namespace Fashion.Mobile;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(PopularPage),typeof(PopularPage));
		Routing.RegisterRoute(nameof(DetalhesPage),typeof(DetalhesPage));
	}
}
