namespace TradeCompanyWF.UserControls
{
    partial class manageContol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageContol));
            this.manageTabControl = new System.Windows.Forms.TabControl();
            this.suppliersTabPage = new System.Windows.Forms.TabPage();
            this.suppliersGridView = new System.Windows.Forms.DataGridView();
            this.supBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.blockedSupTabPage = new System.Windows.Forms.TabPage();
            this.addSupplierTabPage = new System.Windows.Forms.TabPage();
            this.saveSupButton = new System.Windows.Forms.Button();
            this.ratingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.isCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.orgLabel = new System.Windows.Forms.Label();
            this.sNameTextBox = new System.Windows.Forms.TextBox();
            this.sNameLabel = new System.Windows.Forms.Label();
            this.manageTabControl.SuspendLayout();
            this.suppliersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supBindingNavigator)).BeginInit();
            this.supBindingNavigator.SuspendLayout();
            this.addSupplierTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // manageTabControl
            // 
            this.manageTabControl.Controls.Add(this.suppliersTabPage);
            this.manageTabControl.Controls.Add(this.blockedSupTabPage);
            this.manageTabControl.Controls.Add(this.addSupplierTabPage);
            this.manageTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageTabControl.Location = new System.Drawing.Point(0, 0);
            this.manageTabControl.Name = "manageTabControl";
            this.manageTabControl.SelectedIndex = 0;
            this.manageTabControl.ShowToolTips = true;
            this.manageTabControl.Size = new System.Drawing.Size(1135, 744);
            this.manageTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.manageTabControl.TabIndex = 0;
            this.manageTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.manageTabControl_Selecting);
            // 
            // suppliersTabPage
            // 
            this.suppliersTabPage.Controls.Add(this.suppliersGridView);
            this.suppliersTabPage.Controls.Add(this.supBindingNavigator);
            this.suppliersTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.suppliersTabPage.ForeColor = System.Drawing.Color.Black;
            this.suppliersTabPage.Location = new System.Drawing.Point(4, 29);
            this.suppliersTabPage.Name = "suppliersTabPage";
            this.suppliersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.suppliersTabPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.suppliersTabPage.Size = new System.Drawing.Size(1127, 711);
            this.suppliersTabPage.TabIndex = 0;
            this.suppliersTabPage.Text = "Suppliers";
            this.suppliersTabPage.ToolTipText = "List of unblocked suppliers";
            this.suppliersTabPage.UseVisualStyleBackColor = true;
            // 
            // suppliersGridView
            // 
            this.suppliersGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.suppliersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliersGridView.Location = new System.Drawing.Point(3, 34);
            this.suppliersGridView.Name = "suppliersGridView";
            this.suppliersGridView.RowTemplate.Height = 28;
            this.suppliersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.suppliersGridView.Size = new System.Drawing.Size(1121, 674);
            this.suppliersGridView.TabIndex = 1;
            // 
            // supBindingNavigator
            // 
            this.supBindingNavigator.AddNewItem = null;
            this.supBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.supBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.supBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.supBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.supBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.supBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.supBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.supBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.supBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.supBindingNavigator.Name = "supBindingNavigator";
            this.supBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.supBindingNavigator.Size = new System.Drawing.Size(1121, 31);
            this.supBindingNavigator.TabIndex = 0;
            this.supBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // blockedSupTabPage
            // 
            this.blockedSupTabPage.Location = new System.Drawing.Point(4, 29);
            this.blockedSupTabPage.Name = "blockedSupTabPage";
            this.blockedSupTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.blockedSupTabPage.Size = new System.Drawing.Size(1127, 711);
            this.blockedSupTabPage.TabIndex = 1;
            this.blockedSupTabPage.Text = "Blocked Suppliers";
            this.blockedSupTabPage.ToolTipText = "List of blocked suppliers";
            this.blockedSupTabPage.UseVisualStyleBackColor = true;
            // 
            // addSupplierTabPage
            // 
            this.addSupplierTabPage.Controls.Add(this.saveSupButton);
            this.addSupplierTabPage.Controls.Add(this.ratingNumericUpDown);
            this.addSupplierTabPage.Controls.Add(this.isCompanyComboBox);
            this.addSupplierTabPage.Controls.Add(this.ratingLabel);
            this.addSupplierTabPage.Controls.Add(this.orgLabel);
            this.addSupplierTabPage.Controls.Add(this.sNameTextBox);
            this.addSupplierTabPage.Controls.Add(this.sNameLabel);
            this.addSupplierTabPage.Location = new System.Drawing.Point(4, 29);
            this.addSupplierTabPage.Name = "addSupplierTabPage";
            this.addSupplierTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addSupplierTabPage.Size = new System.Drawing.Size(1127, 711);
            this.addSupplierTabPage.TabIndex = 2;
            this.addSupplierTabPage.Text = "Add Supplier";
            this.addSupplierTabPage.ToolTipText = "Add new supplier here";
            this.addSupplierTabPage.UseVisualStyleBackColor = true;
            this.addSupplierTabPage.Leave += new System.EventHandler(this.addSupplierTabPage_Leave);
            // 
            // saveSupButton
            // 
            this.saveSupButton.BackColor = System.Drawing.Color.Black;
            this.saveSupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveSupButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveSupButton.Location = new System.Drawing.Point(13, 200);
            this.saveSupButton.Name = "saveSupButton";
            this.saveSupButton.Size = new System.Drawing.Size(562, 91);
            this.saveSupButton.TabIndex = 8;
            this.saveSupButton.Text = "SAVE";
            this.saveSupButton.UseVisualStyleBackColor = false;
            this.saveSupButton.Click += new System.EventHandler(this.saveSupButton_Click);
            // 
            // ratingNumericUpDown
            // 
            this.ratingNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingNumericUpDown.Location = new System.Drawing.Point(322, 137);
            this.ratingNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ratingNumericUpDown.Name = "ratingNumericUpDown";
            this.ratingNumericUpDown.ReadOnly = true;
            this.ratingNumericUpDown.Size = new System.Drawing.Size(97, 44);
            this.ratingNumericUpDown.TabIndex = 7;
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
            this.isCompanyComboBox.Location = new System.Drawing.Point(322, 76);
            this.isCompanyComboBox.Name = "isCompanyComboBox";
            this.isCompanyComboBox.Size = new System.Drawing.Size(156, 45);
            this.isCompanyComboBox.TabIndex = 6;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingLabel.Location = new System.Drawing.Point(6, 144);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(135, 37);
            this.ratingLabel.TabIndex = 4;
            this.ratingLabel.Text = "Rating :";
            // 
            // orgLabel
            // 
            this.orgLabel.AutoSize = true;
            this.orgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgLabel.Location = new System.Drawing.Point(-1, 84);
            this.orgLabel.Name = "orgLabel";
            this.orgLabel.Size = new System.Drawing.Size(317, 37);
            this.orgLabel.TabIndex = 2;
            this.orgLabel.Text = "Company(Yes/No) :";
            // 
            // sNameTextBox
            // 
            this.sNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sNameTextBox.Location = new System.Drawing.Point(322, 13);
            this.sNameTextBox.Name = "sNameTextBox";
            this.sNameTextBox.Size = new System.Drawing.Size(253, 44);
            this.sNameTextBox.TabIndex = 1;
            // 
            // sNameLabel
            // 
            this.sNameLabel.AutoSize = true;
            this.sNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sNameLabel.Location = new System.Drawing.Point(-1, 20);
            this.sNameLabel.Name = "sNameLabel";
            this.sNameLabel.Size = new System.Drawing.Size(256, 37);
            this.sNameLabel.TabIndex = 0;
            this.sNameLabel.Text = "Supplier name :";
            // 
            // manageContol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.manageTabControl);
            this.Name = "manageContol";
            this.Size = new System.Drawing.Size(1135, 744);
            this.manageTabControl.ResumeLayout(false);
            this.suppliersTabPage.ResumeLayout(false);
            this.suppliersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supBindingNavigator)).EndInit();
            this.supBindingNavigator.ResumeLayout(false);
            this.supBindingNavigator.PerformLayout();
            this.addSupplierTabPage.ResumeLayout(false);
            this.addSupplierTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl manageTabControl;
        private System.Windows.Forms.TabPage suppliersTabPage;
        private System.Windows.Forms.TabPage blockedSupTabPage;
        private System.Windows.Forms.DataGridView suppliersGridView;
        private System.Windows.Forms.BindingNavigator supBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabPage addSupplierTabPage;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label orgLabel;
        private System.Windows.Forms.TextBox sNameTextBox;
        private System.Windows.Forms.Label sNameLabel;
        private System.Windows.Forms.ComboBox isCompanyComboBox;
        private System.Windows.Forms.NumericUpDown ratingNumericUpDown;
        private System.Windows.Forms.Button saveSupButton;
    }
}
