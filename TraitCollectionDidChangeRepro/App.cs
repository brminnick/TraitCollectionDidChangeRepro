using Xamarin.Forms;

namespace TraitCollectionDidChangeRepro
{
    public partial class App : Application
    {
        public App() => MainPage = new NavigationPage(new MainPage());
    }
}
