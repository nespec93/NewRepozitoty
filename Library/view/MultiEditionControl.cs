using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace view
{
    public partial class MultiEditionControl : UserControl
    {
        public MultiEditionControl()
        {
            InitializeComponent();
        }
        public MultiEdition GetMultiEdition()
        {
            return new MultiEdition()
            {
                Author = AuthorTextBox.Text,
                Editor = EditorTextBox.Text,
                Name = NameTextBox.Text,
                TypeOfPublication = (TypeTextBox.Text),
                PublishingHouse = (HouseTextBox.Text),
                CountOfVolume = Convert.ToInt32(CountTextBox.Text),
                
                

            };
        }
   

    }
}
