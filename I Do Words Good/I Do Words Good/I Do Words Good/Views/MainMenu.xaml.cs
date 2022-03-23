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

        private void NewGameBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
