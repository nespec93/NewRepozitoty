namespace view
{
    partial class SourceForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SourceDataGridView = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.normativeDocumentControlInfo = new view.NormativeDocumentControl();
            this.dissertationControlInfo = new view.DissertationControl();
            this.multiEditionControlInfo = new view.MultiEditionControl();
            ((System.ComponentModel.ISupportInitialize)(this.SourceDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SourceDataGridView
            // 
            this.SourceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SourceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SourceDataGridView.Location = new System.Drawing.Point(12, 12);
            this.SourceDataGridView.Name = "SourceDataGridView";
            this.SourceDataGridView.Size = new System.Drawing.Size(408, 353);
            this.SourceDataGridView.TabIndex = 0;
            this.SourceDataGridView.SelectionChanged += new System.EventHandler(this.SourceDataGridView_SelectionChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 371);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(65, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add literary source";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(183, 371);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(65, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(355, 371);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(65, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.normativeDocumentControlInfo);
            this.groupBox1.Controls.Add(this.dissertationControlInfo);
            this.groupBox1.Controls.Add(this.multiEditionControlInfo);
            this.groupBox1.Location = new System.Drawing.Point(432, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 188);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // normativeDocumentControlInfo
            // 
            this.normativeDocumentControlInfo.Location = new System.Drawing.Point(6, 22);
            this.normativeDocumentControlInfo.Name = "normativeDocumentControlInfo";
            this.normativeDocumentControlInfo.Size = new System.Drawing.Size(420, 141);
            this.normativeDocumentControlInfo.TabIndex = 7;
            this.normativeDocumentControlInfo.Visible = false;
            // 
            // dissertationControlInfo
            // 
            this.dissertationControlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dissertationControlInfo.Location = new System.Drawing.Point(6, 19);
            this.dissertationControlInfo.Name = "dissertationControlInfo";
            this.dissertationControlInfo.Size = new System.Drawing.Size(420, 132);
            this.dissertationControlInfo.TabIndex = 4;
            this.dissertationControlInfo.Visible = false;
            // 
            // multiEditionControlInfo
            // 
            this.multiEditionControlInfo.Location = new System.Drawing.Point(6, 22);
            this.multiEditionControlInfo.Name = "multiEditionControlInfo";
            this.multiEditionControlInfo.Size = new System.Drawing.Size(420, 160);
            this.multiEditionControlInfo.TabIndex = 6;
            this.multiEditionControlInfo.Visible = false;
            // 
            // SourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 406);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SourceDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SourceForm";
            this.Text = "SourceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SourceForm_FormClosing);
            this.Load += new System.EventHandler(this.SourceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SourceDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SourceDataGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button CloseButton;
        private DissertationControl dissertationControlInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private MultiEditionControl multiEditionControlInfo;
        private NormativeDocumentControl normativeDocumentControlInfo;
    }
}

