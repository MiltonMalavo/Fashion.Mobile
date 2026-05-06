namespace Fashion.Mobile.Pages;

public partial class PopularPage : ContentPage
{
	public PopularPage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
	{
		var res = (sender as Border).BindingContext as Product;
		Preferences.Set("id",res.Id);
		await Shell.Current.GoToAsync(nameof(DetalhesPage), animate:true);
	}
}