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
        private NormativeDocumentControl _normControl = new NormativeDocumentControl();


        private void DissertationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //DissertationControl dissertationControl = new DissertationControl();
            SourceGroupBox.Controls.Clear();
            SourceGroupBox.Controls.Add(_dissertationControl);
            _dissertationControl.Location = new Point(3, 11);
            _dissertationControl.Size = new Size(SourceGroupBox.Width - 10, _dissertationControl.Height);
            _dissertationControl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            _dissertationControl.Visible = true;
        }

        private void MultiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //MultiEditionControl multiControl = new MultiEditionControl();
            SourceGroupBox.Controls.Clear();
            SourceGroupBox.Controls.Add(_multiControl);
            _multiControl.Location = new Point(3, 11);
            _multiControl.Size = new Size(SourceGroupBox.Width - 10, _multiControl.Height);
            _multiControl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            _multiControl.Visible = true;
        }
        private void NormRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //NormativeDocumentControl normControl = new NormativeDocumentControl();
            SourceGroupBox.Controls.Clear();
            SourceGroupBox.Controls.Add(_normControl);
            _normControl.Location = new Point(3, 11);
            _normControl.Size = new Size(SourceGroupBox.Width - 10, _normControl.Height);
            _normControl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            _normControl.Visible = true;
        }


        public IReferences GetLiterarySource()
        {

            if (DissertationRadioButton.Checked)
            {
                LiterarySource = _dissertationControl.GetDissertation();
            }
            if (MultiRadioButton.Checked)
            {
                LiterarySource = _multiControl.GetMultiEdition();
            }
            if (NormRadioButton.Checked)
            {
                LiterarySource = _normControl.GetNormDocument();
            }
         
            return LiterarySource;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SourceGroupBox_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
