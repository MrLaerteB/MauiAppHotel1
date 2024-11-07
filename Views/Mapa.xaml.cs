namespace MauiAppHotel.Views;

public partial class Mapa : ContentPage
{
    public Mapa()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var url = "https://www.google.com/maps/place/Ilha+de+Martim+Vaz";
        if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
        {
            await Launcher.Default.OpenAsync(url);
        }
    }
}