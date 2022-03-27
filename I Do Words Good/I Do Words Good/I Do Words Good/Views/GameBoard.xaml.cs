using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace I_Do_Words_Good.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GameBoard : ContentPage
    {
        private int Length { get; set; }
        public GameBoard(int length)
        {
            InitializeComponent();
            Length = length;
        }
    }
}