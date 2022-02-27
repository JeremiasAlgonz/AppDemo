using AwesomeApp.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Sucesso", "Cadastro Finalizado!", "Ok");
        }

        private void TapGestureRecognizer_ProfilePic_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Nova foto de perfil", "Selecionar diretório de imagem: ", "Select");
        }
    }
}