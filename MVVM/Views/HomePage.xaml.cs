using BibliotekaGierMAUI.Services;
using BibliotekaGierMAUI.ViewModels;
namespace BibliotekaGierMAUI.MVVM.Views;

public partial class HomePage : ContentPage
{
    public HomePage(IGamesService games)
    {
        InitializeComponent();
        this.BindingContext = new HomeViewModel(games);
    }

    private async void ShowAllTags_Animation(object sender, EventArgs e)
    {
        var button = (Button)sender;
        await button.ScaleTo(0.95, 50, Easing.CubicOut);
        await button.ScaleTo(1, 50, Easing.CubicIn);
    }

}
