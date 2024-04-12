using BibliotekaGierMAUI.Services;
using Microsoft.Maui.Controls.StyleSheets;


namespace BibliotekaGierMAUI.MVVM.Views;

public partial class LoginPage : ContentPage
{
    private readonly IGamesService _gamesService;
    public LoginPage(IGamesService gamesService)
    {
        _gamesService = gamesService;
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string user_login = login.Text; 
        string user_password = password.Text;

        if ( user_login == "admin" && user_password == "admin")
        {
            await DisplayAlert("Logowanie udane!", "Uda³o siê zalogowaæ", "OK");
            await Navigation.PushAsync(new GamePage(_gamesService));
        }
        else
        {
            await DisplayAlert("B³¹d logowania", "Niepoprawny login lub has³o", "OK");
        }
    }

}
