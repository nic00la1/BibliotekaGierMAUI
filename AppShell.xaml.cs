using BibliotekaGierMAUI.MVVM.Views;

namespace BibliotekaGierMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("game", typeof(GamePage));
            Routing.RegisterRoute("category", typeof(CategoryPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        }
    }
}
