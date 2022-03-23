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
    public partial class InputRow : ContentView
    {
        public List<InputCell> Cells { get; set; }
        public InputRow(int length)
        {
            Cells = new List<InputCell>();
            InitializeComponent();
            AddCellsToRow(length);
        }

        public void AddLetter(char letter)
        {
            for(int i = 0; i< Cells.Count; i++)
            {
                if(Cells[i] == null)
                {
                    Cells[i].SetLetter(letter);
                    return;
                }
            }
        }

        public void RemoveLetter()
        {
            for(int i = Cells.Count - 1; i >= 0; i--)
            {
                if(Cells[i].Letter != null)
                {
                    Cells[i].RemoveLetter();
                    return;
                }
            }
            return;
        }

        private void AddCellsToRow(int length)
        {
            for(int i = 0; i<length; ++i)
            {
                CellRow.Children.Add(new InputCell());
            }
        }

    }
}