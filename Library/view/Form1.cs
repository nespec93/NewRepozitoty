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
    public partial class SourceForm : Form
    {
        private IReferences source;
        public DataTable LiterarySources { get; set; }

        public SourceForm()
        {
            InitializeComponent();
            LiterarySources = new DataTable();
            var column = new DataColumn()
            {
                Caption = "LiterarySource",
                ColumnName = "LiterarySource",
                ReadOnly = true,
                DataType = typeof (string)
            };
            LiterarySources.Columns.Add(column);
            column = new DataColumn()
            {
                Caption = "GetDescription",
                ColumnName = "GetDescription",
                ReadOnly = true,
                DataType = typeof (string)
            };
            LiterarySources.Columns.Add(column);
            SourceDataGridView.DataSource = LiterarySources;
            foreach (DataGridViewColumn col in SourceDataGridView.Columns)
                SourceDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            AddSourceForm sourceForm = new AddSourceForm();
            sourceForm.ShowDialog();

            if (sourceForm.DialogResult != DialogResult.Cancel)
            {
                var newRow = LiterarySources.NewRow();
                source = sourceForm.GetLiterarySource();
                if (source is Dissertation)
                {
                    newRow[0] = "Dissertation";
                }
                //if (source is JournalArticle)
                //{
                //    newRow[0] = "JournalArticle";
                //}
                //if (source is ElectronicResource)
                //{
                //    newRow[0] = "ElectronicResource";
                //}
                newRow[1] = source.GetDescription();
                LiterarySources.Rows.Add(newRow);
            }


        }
    }
}
