namespace TradeCompanyWF
{
    partial class EditSupplierForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.isCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.orgLabel = new System.Windows.Forms.Label();
            this.sNameTextBox = new System.Windows.Forms.TextBox();
            this.sNameLabel = new System.Windows.Forms.Label();
            this.rNumDrop = new System.Windows.Forms.NumericUpDown();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.blockCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.rNumDrop)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(509, 417);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(90, 48);
            this.buttonOk.TabIndex = 15;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(423, 417);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 48);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // isCompanyComboBox
            // 
            this.isCompanyComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Company",
            "Private"});
            this.isCompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isCompanyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isCompanyComboBox.FormattingEnabled = true;
            this.isCompanyComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.isCompanyComboBox.Location = new System.Drawing.Point(335, 82);
            this.isCompanyComboBox.Name = "isCompanyComboBox";
            this.isCompanyComboBox.Size = new System.Drawing.Size(156, 45);
            this.isCompanyComboBox.TabIndex = 19;
            // 
            // orgLabel
            // 
            this.orgLabel.AutoSize = true;
            this.orgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgLabel.Location = new System.Drawing.Point(12, 90);
            this.orgLabel.Name = "orgLabel";
            this.orgLabel.Size = new System.Drawing.Size(317, 37);
            this.orgLabel.TabIndex = 18;
            this.orgLabel.Text = "Company(Yes/No) :";
            // 
            // sNameTextBox
            // 
            this.sNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sNameTextBox.Location = new System.Drawing.Point(335, 19);
            this.sNameTextBox.Name = "sNameTextBox";
            this.sNameTextBox.Size = new System.Drawing.Size(253, 44);
            this.sNameTextBox.TabIndex = 17;
            // 
            // sNameLabel
            // 
            this.sNameLabel.AutoSize = true;
            this.sNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sNameLabel.Location = new System.Drawing.Point(12, 26);
            this.sNameLabel.Name = "sNameLabel";
            this.sNameLabel.Size = new System.Drawing.Size(256, 37);
            this.sNameLabel.TabIndex = 16;
            this.sNameLabel.Text = "Supplier name :";
            // 
            // rNumDrop
            // 
            this.rNumDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rNumDrop.Location = new System.Drawing.Point(335, 162);
            this.rNumDrop.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rNumDrop.Name = "rNumDrop";
            this.rNumDrop.ReadOnly = true;
            this.rNumDrop.Size = new System.Drawing.Size(97, 44);
            this.rNumDrop.TabIndex = 22;
            this.rNumDrop.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingLabel.Location = new System.Drawing.Point(12, 162);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(135, 37);
            this.ratingLabel.TabIndex = 21;
            this.ratingLabel.Text = "Rating :";
            // 
            // blockCheckBox
            // 
            this.blockCheckBox.AutoSize = true;
            this.blockCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blockCheckBox.Location = new System.Drawing.Point(12, 225);
            this.blockCheckBox.Name = "blockCheckBox";
            this.blockCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.blockCheckBox.Size = new System.Drawing.Size(261, 41);
            this.blockCheckBox.TabIndex = 24;
            this.blockCheckBox.Text = "Block Supplier";
            this.blockCheckBox.UseVisualStyleBackColor = true;
            // 
            // EditSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 479);
            this.Controls.Add(this.blockCheckBox);
            this.Controls.Add(this.rNumDrop);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.isCompanyComboBox);
            this.Controls.Add(this.orgLabel);
            this.Controls.Add(this.sNameTextBox);
            this.Controls.Add(this.sNameLabel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Name = "EditSupplierForm";
            this.Text = "EditSupplierForm";
            ((System.ComponentModel.ISupportInitialize)(this.rNumDrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox isCompanyComboBox;
        private System.Windows.Forms.Label orgLabel;
        private System.Windows.Forms.TextBox sNameTextBox;
        private System.Windows.Forms.Label sNameLabel;
        private System.Windows.Forms.NumericUpDown rNumDrop;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox blockCheckBox;
    }
}