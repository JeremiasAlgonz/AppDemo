using Xamarin.Forms;

namespace AwesomeApp.Pages
{
    class SaboresPage : BasePage
    {

        public SaboresPage()
        {
            Title = "Sabores";

            var lista = new ListView
            {
                ItemsSource = new[]
            {
                "Calabresa",
                "Portuguesa",
                "Mussarela",
                "Paulista",
            }
            };

            lista.ItemTapped += (sender, e) =>
            {
                DisplayAlert("Sabor", (string)((ListView)sender).SelectedItem, "OK");
                ((ListView)sender).SelectedItem = null;
            };

            Content = lista;
        }

    }
}
