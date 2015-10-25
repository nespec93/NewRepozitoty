using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace view
{
    public partial class AddSourceForm : Form
    {
        public AddSourceForm()
        {
            InitializeComponent();
        }

        public IReferences LiterarySource { get; set; }

        private DissertationControl _dissertationControl = new DissertationControl();
        private MultiEditionControl _multiControl = new MultiEditionControl();


        private void DissertationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DissertationControl dissertationControl = new DissertationControl();
            SourceGroupBox.Controls.Clear();
            SourceGroupBox.Controls.Add(dissertationControl);
            dissertationControl.Location = new Point(3, 11);
            dissertationControl.Size = new Size(SourceGroupBox.Width - 20, dissertationControl.Height);
            dissertationControl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            dissertationControl.Visible = true;
        }

        private void MultiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MultiEditionControl multiControl = new MultiEditionControl();
            SourceGroupBox.Controls.Clear();
            SourceGroupBox.Controls.Add(multiControl);
            multiControl.Location = new Point(3, 11);
            multiControl.Size = new Size(SourceGroupBox.Width - 20, multiControl.Height);
            multiControl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            multiControl.Visible = true;
        }

        public IReferences GetLiterarySource()
        {

            if (DissertationRadioButton.Checked)
            {
                LiterarySource = _dissertationControl.GetDissertation();
            }
            //if (ElectronicResourceRadioButton.Checked)
            //{
            //    LiterarySource = _electronicResourceControl.GetElectronicResource();
            //}
            //if (JournalArticleRadioButton.Checked)
            //{
            //    LiterarySource = _journalArticleControl.GetJournalArticle();
            //}
            return LiterarySource;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
