﻿using System;
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
    public partial class NormativeDocumentControl : UserControl
    {
        public NormativeDocumentControl()
        {
            InitializeComponent();
        }

        public NormDocument GetNormDocument()
        {
            return new NormDocument()
            {
                NameOfDoc = AuthorTextBox.Text,
                TitleOfDoc = TitleTextBox.Text,
                InfoForDoc = ScientificTextBox.Text,
                YearAndMonth = (PlaceTextBox.Text),
                Number = Convert.ToInt32(PublisherTextBox.Text),
                ImprintYear = Convert.ToInt32(YearTextBox.Text),
                NumberOfpages = Convert.ToInt32(NumberOfPagesTextBox.Text)

            };
        }

        public void SetNormDocument(NormDocument normDocument)
        {
            AuthorTextBox.Text = normDocument.NameOfDoc;
            TitleTextBox.Text = normDocument.TitleOfDoc;
            ScientificTextBox.Text = normDocument.InfoForDoc;
            PlaceTextBox.Text = normDocument.YearAndMonth;
            PublisherTextBox.Text = normDocument.Number.ToString();
            YearTextBox.Text = normDocument.ImprintYear.ToString();
            NumberOfPagesTextBox.Text = normDocument.NumberOfpages.ToString();
        }

       
    

       
    }
}
