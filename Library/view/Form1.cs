using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Model;

namespace view
{
    public partial class SourceForm : Form
    {
        //private IReferences source;
        private List<IReferences> sourcesList;
        public DataTable LiterarySources { get; set; }

        public SourceForm()
        {
            InitializeComponent();
            LiterarySources = new DataTable();
            var column = new DataColumn()
            {
                Caption = "Literary Source",
                ColumnName = "LiterarySource",
                ReadOnly = true,
                DataType = typeof (string)
            };
            LiterarySources.Columns.Add(column);
            column = new DataColumn()
            {
                Caption = "Description",
                ColumnName = "GetDescription",
                ReadOnly = true,
                DataType = typeof (string)
            };
            LiterarySources.Columns.Add(column);
            SourceDataGridView.DataSource = LiterarySources;
            SourceDataGridView.Columns[0].Width = 120;
            SourceDataGridView.Columns[1].Width = 225;

            SourceDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sourcesList = new List<IReferences>();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            AddSourceForm sourceForm = new AddSourceForm();
            sourceForm.ShowDialog();

            if (sourceForm.DialogResult != DialogResult.Cancel)
            {
                IReferences source = sourceForm.GetLiterarySource();
                sourcesList.Add(source);
                AddRow(source);
            }
        }

        private void AddRow(IReferences source)
        {
            var newRow = LiterarySources.NewRow();
            newRow[0] = source.GetType();
            newRow[1] = source.GetDescription();
            LiterarySources.Rows.Add(newRow);       
        }

        private void SourceDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dissertationControlInfo.Visible = false;
            multiEditionControlInfo.Visible = false;
            normativeDocumentControlInfo.Visible = false;
            if (SourceDataGridView.CurrentRow == null)
                return;
            int idx = SourceDataGridView.CurrentRow.Index;
            if (idx < sourcesList.Count)
            {
                IReferences source = sourcesList[idx];
                switch(source.GetType().ToString())
                {
                    case "Model.Dissertation":
                        dissertationControlInfo.Visible = true;
                        dissertationControlInfo.SetDissertation((Dissertation)source);
                        break;

                    case "Model.MultiEdition":
                        multiEditionControlInfo.Visible = true;
                        multiEditionControlInfo.SetMultiEdition((MultiEdition)source);
                        break;

                    case "Model.NormDocument":
                        normativeDocumentControlInfo.Visible = true;
                        normativeDocumentControlInfo.SetNormDocument((NormDocument)source);
                        break;
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
             if (SourceDataGridView.CurrentRow == null)
                return;
            int idx = SourceDataGridView.CurrentRow.Index;
            if (idx < sourcesList.Count)
            {
                dissertationControlInfo.Visible = false;
                multiEditionControlInfo.Visible = false;
                normativeDocumentControlInfo.Visible = false;
                sourcesList.RemoveAt(idx);
                LiterarySources.Rows.RemoveAt(idx);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SourceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //СЕРИАЛИЗАЦИЯ
            List<Dissertation> dissertations = new List<Dissertation>();
            List<MultiEdition> multiEditions = new List<MultiEdition>();
            List<NormDocument> normDocuments = new List<NormDocument>();

            foreach (IReferences source in sourcesList)
            {
                switch (source.GetType().ToString())
                {
                    case "Model.Dissertation":
                        dissertations.Add((Dissertation)source);
                        break;

                    case "Model.MultiEdition":
                        multiEditions.Add((MultiEdition)source);
                        break;

                    case "Model.NormDocument":
                        normDocuments.Add((NormDocument)source);
                        break;
                }
            }

            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Dissertation>));
            using (var file = System.IO.File.Create("Dissertations.xml"))
            {
                writer.Serialize(file, dissertations);
                file.Close();
            }


            writer = new System.Xml.Serialization.XmlSerializer(typeof(List<MultiEdition>));
            using (var file = System.IO.File.Create("MultiEditions.xml"))
            {
                writer.Serialize(file, multiEditions);
                file.Close();
            }

            writer = new System.Xml.Serialization.XmlSerializer(typeof(List<NormDocument>));
            using (var file = System.IO.File.Create("NormDocuments.xml"))
            {
                writer.Serialize(file, normDocuments);
                file.Close();
            } 
            
        }

        private void SourceForm_Load(object sender, EventArgs e)
        {
            //ДЕСЕРИАЛИЗАЦИЯ
            List<Dissertation> dissertations = new List<Dissertation>();
            List<MultiEdition> multiEditions = new List<MultiEdition>();
            List<NormDocument> normDocuments = new List<NormDocument>();

            if (File.Exists("Dissertations.xml"))
            {
                var reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Dissertation>));
                var file = new System.IO.StreamReader("Dissertations.xml");
                dissertations = (List<Dissertation>)reader.Deserialize(file);
                file.Close();
            }

            if (File.Exists("MultiEditions.xml"))
            {
                var reader = new System.Xml.Serialization.XmlSerializer(typeof(List<MultiEdition>));
                var file = new System.IO.StreamReader("MultiEditions.xml");
                multiEditions = (List<MultiEdition>)reader.Deserialize(file);
                file.Close();
            }

            if (File.Exists("NormDocuments.xml"))
            {
                var reader = new System.Xml.Serialization.XmlSerializer(typeof(List<NormDocument>));
                var file = new System.IO.StreamReader("NormDocuments.xml");
                normDocuments = (List<NormDocument>)reader.Deserialize(file);
                file.Close();
            }

            sourcesList.AddRange(dissertations);
            sourcesList.AddRange(multiEditions);
            sourcesList.AddRange(normDocuments);
            foreach (IReferences source in sourcesList)
            {
                AddRow(source);
            }
        }
    }
}
