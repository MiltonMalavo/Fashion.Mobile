namespace Fashion.Mobile.Pages;
[QueryProperty(nameof(Id), "id")]
public partial class DetalhesPage : ContentPage
{
	public string Id { get; set; }
	public DetalhesPage()
	{
		InitializeComponent();
	}
}