using Xamarin.Forms;
using Xamarin.Forms.Maps;



namespace AwesomeApp.Pages
{
    class MapaPage : ContentPage
    {
        public MapaPage()
        {
            var posicao = new Position(-25.474253f, -49.349416f);

            var mapa = new Map(MapSpan.FromCenterAndRadius(posicao, Distance.FromKilometers(0.3f)))
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            mapa.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Position = posicao,
                Label = "Pizzaria XYL",
                Address = "Rua da Pizzaria, 1234"

            });

            Content = new StackLayout
            {
                Children =
                {
                    mapa
                }
            };
        }
    }
}
