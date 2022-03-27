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
    public partial class Key : ContentView
    {
        public string Value { get; set; }
        private bool IsEnter { get; set; }
        private bool IsBack { get; set; }

        /*public Key()
        {
            InitializeComponent();
        }
        
        public void SetValue(string keyValue)
        {
            Value = keyValue;
            KeyLbl.Text = Value;
        }*/

        public Key(string keyValue)
        {
            Value = keyValue;
            InitializeComponent();
            KeyBtn.Text = Value;
            if (Value == "ENTER")
            {
                IsEnter = true;
                KeyBtn.WidthRequest = 70;
            }
            else if (Value == "BACK")
            {
                IsBack = true;
                KeyBtn.WidthRequest = 65;
            }
            else
            {
                KeyBtn.WidthRequest = 30;
            }
            KeyBtn.Padding = new Thickness(0, 0, 0, 0);
        }

        public void SetEnter(bool enter)
        {
            IsEnter = enter;
        }
        public void SetBack(bool back)
        {
            IsBack = back;
        }

        private void KeyBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}