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
    public partial class DissertationControl : UserControl
    {
        public DissertationControl()
        {
            InitializeComponent();
        }

        public Dissertation GetDissertation()
        {
            //var year = Convert.ToInt32(YearTextBox.Text);
           // var pages = Convert.ToInt32(NumberOfPagesTextBox.Text);
            return new Dissertation
            {
                
                Author = AuthorTextBox.Text,
                ThesisTitle = TitleTextBox.Text,
                ScientificDegrees = ScientificTextBox.Text,
                PlaceOfPublication = PlaceTextBox.Text,
                Publisher = PublisherTextBox.Text,
                NumberOfpages = Convert.ToInt32(NumberOfPagesUpDown.Value)
               // ImprintYear = year,
              //  NumberOfpages = pages
            };

        }
        
       

    }
}
