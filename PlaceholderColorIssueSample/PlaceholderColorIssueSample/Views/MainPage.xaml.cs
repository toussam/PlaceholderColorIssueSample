using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlaceholderColorIssueSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private SecondPage secondPage;

        public MainPage()
        {
            InitializeComponent();

            secondPage = new SecondPage();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation?.PushAsync(secondPage);
        }
    }
}