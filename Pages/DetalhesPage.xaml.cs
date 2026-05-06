namespace Fashion.Mobile.Pages;
[QueryProperty(nameof(Id), "id")]
public partial class DetalhesPage : ContentPage
{
	public DetalhesViewModels _detalhesViewModels;
	public DetalhesPage()
	{
		InitializeComponent();
		_detalhesViewModels = new DetalhesViewModels();
		BindingContext = _detalhesViewModels;
	}
}