using Xamarin.Forms;
using AwesomeApp.Pages;

namespace AwesomeApp
{
    public class MenuPage : TabbedPage
    {
        public MenuPage()
        {
            Title = "Menu";


            Children.Add(new IndexPage()
            {
                Title = "Início"
            });

            Children.Add(new SaboresPage()
            {
                Title = "Sabores"
            });

            Children.Add(new MapaPage()
            {
                Title = "Mapa"
            });

        }

    }
}