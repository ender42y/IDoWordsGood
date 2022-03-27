using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace I_Do_Words_Good.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : ContentPage
    {

        public MainMenu()
        {
            InitializeComponent();

            
        }

        private void WordOfTheDayBtn_Clicked(object sender, EventArgs e)
        {
            
        }

        private async void NewGameBtn_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayActionSheet("Word Length","Back",null, "3", "4", "5", "6", "7");
            int length = int.Parse(result);
            await Navigation.PushAsync(new GameBoard(length));
        }
    }
}
