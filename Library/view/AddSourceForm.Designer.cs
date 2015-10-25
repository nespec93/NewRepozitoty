namespace view
{
    partial class AddSourceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TypeGroupBox = new System.Windows.Forms.GroupBox();
            this.NormRadioButton = new System.Windows.Forms.RadioButton();
            this.MultiRadioButton = new System.Windows.Forms.RadioButton();
            this.DissertationRadioButton = new System.Windows.Forms.RadioButton();
            this.SourceGroupBox = new System.Windows.Forms.GroupBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TypeGroupBox
            // 
            this.TypeGroupBox.Controls.Add(this.NormRadioButton);
            this.TypeGroupBox.Controls.Add(this.MultiRadioButton);
            this.TypeGroupBox.Controls.Add(this.DissertationRadioButton);
            this.TypeGroupBox.Location = new System.Drawing.Point(13, 13);
            this.TypeGroupBox.Name = "TypeGroupBox";
            this.TypeGroupBox.Size = new System.Drawing.Size(117, 94);
            this.TypeGroupBox.TabIndex = 0;
            this.TypeGroupBox.TabStop = false;
            this.TypeGroupBox.Text = "Type";
            // 
            // NormRadioButton
            // 
            this.NormRadioButton.AutoSize = true;
            this.NormRadioButton.Location = new System.Drawing.Point(7, 68);
            this.NormRadioButton.Name = "NormRadioButton";
            this.NormRadioButton.Size = new System.Drawing.Size(100, 17);
            this.NormRadioButton.TabIndex = 2;
            this.NormRadioButton.TabStop = true;
            this.NormRadioButton.Text = "Norm document";
            this.NormRadioButton.UseVisualStyleBackColor = true;
            // 
            // MultiRadioButton
            // 
            this.MultiRadioButton.AutoSize = true;
            this.MultiRadioButton.Location = new System.Drawing.Point(7, 44);
            this.MultiRadioButton.Name = "MultiRadioButton";
            this.MultiRadioButton.Size = new System.Drawing.Size(81, 17);
            this.MultiRadioButton.TabIndex = 1;
            this.MultiRadioButton.TabStop = true;
            this.MultiRadioButton.Text = "Multi edition";
            this.MultiRadioButton.UseVisualStyleBackColor = true;
            this.MultiRadioButton.CheckedChanged += new System.EventHandler(this.MultiRadioButton_CheckedChanged);
            // 
            // DissertationRadioButton
            // 
            this.DissertationRadioButton.AutoSize = true;
            this.DissertationRadioButton.Location = new System.Drawing.Point(7, 20);
            this.DissertationRadioButton.Name = "DissertationRadioButton";
            this.DissertationRadioButton.Size = new System.Drawing.Size(80, 17);
            this.DissertationRadioButton.TabIndex = 0;
            this.DissertationRadioButton.TabStop = true;
            this.DissertationRadioButton.Text = "Dissertation";
            this.DissertationRadioButton.UseVisualStyleBackColor = true;
            this.DissertationRadioButton.CheckedChanged += new System.EventHandler(this.DissertationRadioButton_CheckedChanged);
            // 
            // SourceGroupBox
            // 
            this.SourceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceGroupBox.Location = new System.Drawing.Point(137, 13);
            this.SourceGroupBox.Name = "SourceGroupBox";
            this.SourceGroupBox.Size = new System.Drawing.Size(410, 229);
            this.SourceGroupBox.TabIndex = 1;
            this.SourceGroupBox.TabStop = false;
            this.SourceGroupBox.Text = "Source";
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(137, 273);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(471, 272);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddSourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 321);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SourceGroupBox);
            this.Controls.Add(this.TypeGroupBox);
            this.Name = "AddSourceForm";
            this.Text = "AddSourceForm";
            this.TypeGroupBox.ResumeLayout(false);
            this.TypeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TypeGroupBox;
        private System.Windows.Forms.RadioButton NormRadioButton;
        private System.Windows.Forms.RadioButton MultiRadioButton;
        private System.Windows.Forms.RadioButton DissertationRadioButton;
        private System.Windows.Forms.GroupBox SourceGroupBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}