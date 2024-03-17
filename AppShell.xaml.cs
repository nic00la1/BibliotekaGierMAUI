using BibliotekaGierMAUI.MVVM.Views;

namespace BibliotekaGierMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("game", typeof(GamePage));

            this.HomeTab.Icon = ImageSource.FromResource("BibliotekaGierMAUI.Resources.home.png", this.GetType().Assembly);
        }
    }
}
