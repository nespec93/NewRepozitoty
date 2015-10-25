using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Model;

namespace veiw
{
    public partial class LiterarySourceForm : Form
    {
        private DataTable LiterarySources { get; set; }

        private List<ILiterarySource> Literure { get; set; }

        private Dictionary<DataRow, ILiterarySource> hjhk;

        /// <summary>
        /// Главная форма
        /// </summary>
        public LiterarySourceForm()
        {
            InitializeComponent();
            LiterarySources = new DataTable();
            var column = new DataColumn()
            {
                Caption = "LiterarySource",
                ColumnName = "LiterarySource",
                ReadOnly = true,
                DataType = typeof(string)
            };
            LiterarySources.Columns.Add(column);
            column = new DataColumn()
            {
                Caption = "GetDescription",
                ColumnName = "GetDescription",
                ReadOnly = true,
                DataType = typeof(string)
            };
            LiterarySources.Columns.Add(column);
            DescriptionSourceDataGridView.DataSource = LiterarySources;
        }

        /// <summary>
        /// Кнопка при нажатии на которую открывается форма для создания нового объекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addLiterarySourceButton_Click(object sender, EventArgs e)
        {
            AddLiterarySourceForm sourceForm = new AddLiterarySourceForm();
            sourceForm.ShowDialog();
            if (sourceForm.DialogResult == DialogResult.OK)
            {
                var source = sourceForm.LiterarySource;
                LiterarySources.Rows.Add("hytfjhdf", source.GetDescription());
            }

        }

        /// <summary>
        /// Кнопка для закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Создание книги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!bookRadioButton.Checked)
                return;
            ILiterarySource source;

            var book = new Book()
            {
                Author = "Бычкова С.М",
                Title = "Планирование в аудите",
                StatementOfResponsibility = "С.М. Бычкова, А.В.Газорян",
                YearOfManufacture = 2007,
                CountOfPages = 263
            };
            source = book;
            source.GetDescription();
            LiterarySources.Rows.Add("Book", source.GetDescription());
            DescriptionSourceDataGridView.Refresh();
        }

        /// <summary>
        /// Создание статьи из журнала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void journalArticleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!journalArticleRadioButton.Checked)
                return;
            ILiterarySource source;

            var journalArticle = new JournalArticle()
            {
                Author = "Тарасова, Н.Г",
                Title = "Сведения об ответственном: Н.Г. Тарасова",
                StatementOfResponsibility = "Н.Г. Тарасова",
                YearOfManufacture = 2007,
                NameJournal = "Архитектура и строительство России",
                IssueNumber = 4
            };
            source = journalArticle;
            source.GetDescription();
            LiterarySources.Rows.Add("Journal Article", source.GetDescription());
            DescriptionSourceDataGridView.Refresh();
        }

        /// <summary>
        /// Создание электронного ресурса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void electronicResourceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!electronicResourceRadioButton.Checked)
                return;
            ILiterarySource source;

            var electronicResource = new ElectronicResource()
            {
                Author = "Родников, А.Р",
                Title = "Логистика [Электронный ресурс]: терминологический словарь ",
                StatementOfResponsibility = "А.Р. Родников",
                YearOfManufacture = 2000,
                TypeOfResource = "Электронные данные",
                PlaceOfPublication = "Москва",
                PublishingHouse = "ИНФРА-М",
                Series = "1 эл. опт. диск  (CD- ROM)"
            };
            source = electronicResource;
            source.GetDescription();
            LiterarySources.Rows.Add("Electronic Resource", source.GetDescription());
            DescriptionSourceDataGridView.Refresh();
        }
    }
}

