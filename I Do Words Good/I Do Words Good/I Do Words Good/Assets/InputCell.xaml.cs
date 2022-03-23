using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace I_Do_Words_Good.Assets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InputCell : ContentView
    {
        public char? Letter { get; set; }
        public InputCell()
        {
            InitializeComponent();
            Letter = null;
        }

        public void SetLetter(char letter)
        {
            Letter = letter;
        }

        public void RemoveLetter()
        {
            Letter = null;
        }
    }
}