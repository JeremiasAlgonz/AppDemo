using Xamarin.Forms;
using System;

namespace AwesomeApp.Pages
{
    class IndexPage : ContentPage
    {
        public IndexPage()
        {
            var telefone = new Button() { Text = "(41) 1234-5678" };
            telefone.Clicked += (sender, e) => Device.OpenUri(new Uri("tel://4112345678"));
            Content = new ContentView()
            {
                Content = new StackLayout
                {
                    Padding = new Thickness(20,0,20,0),
                    Children =
                    {
                        new Image
                        {
                            Source = "logo.png",
                            Aspect = Aspect.AspectFit,
                            HorizontalOptions = LayoutOptions.Center
                            
                        },

                        telefone
                    }
                },

                VerticalOptions = LayoutOptions.CenterAndExpand

            };
        }
    }
}