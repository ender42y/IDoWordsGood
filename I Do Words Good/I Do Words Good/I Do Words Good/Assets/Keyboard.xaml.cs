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
    public partial class Keyboard : ContentView
    {
        public Keyboard()
        {
            InitializeComponent();
            PopulateTop();
            PopulateMiddle();
            PopulateBottom();
        }

        private void PopulateTop()
        {
            TopRow.Children.Add(new Key("Q"));
            TopRow.Children.Add(new Key("W"));
            TopRow.Children.Add(new Key("E"));
            TopRow.Children.Add(new Key("R"));
            TopRow.Children.Add(new Key("T"));
            TopRow.Children.Add(new Key("Y"));
            TopRow.Children.Add(new Key("U"));
            TopRow.Children.Add(new Key("I"));
            TopRow.Children.Add(new Key("O"));
            TopRow.Children.Add(new Key("P"));
        }

        private void PopulateMiddle()
        {
            MiddleRow.Children.Add(new Key("A"));
            MiddleRow.Children.Add(new Key("S"));
            MiddleRow.Children.Add(new Key("D"));
            MiddleRow.Children.Add(new Key("F"));
            MiddleRow.Children.Add(new Key("G"));
            MiddleRow.Children.Add(new Key("H"));
            MiddleRow.Children.Add(new Key("J"));
            MiddleRow.Children.Add(new Key("K"));
            MiddleRow.Children.Add(new Key("L"));
        }

        private void PopulateBottom()
        {
            BottomRow.Children.Add(new Key("ENTER"));
            BottomRow.Children.Add(new Key("Z"));
            BottomRow.Children.Add(new Key("X"));
            BottomRow.Children.Add(new Key("C"));
            BottomRow.Children.Add(new Key("V"));
            BottomRow.Children.Add(new Key("B"));
            BottomRow.Children.Add(new Key("N"));
            BottomRow.Children.Add(new Key("M"));
            BottomRow.Children.Add(new Key("BACK"));
        }
    }
}