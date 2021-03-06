﻿namespace TradeCompanyWF.UserControls
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.blockedDG = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.addSupplierTabPage = new System.Windows.Forms.TabPage();
            this.saveSupButton = new System.Windows.Forms.Button();
            this.ratingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.isCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.orgLabel = new System.Windows.Forms.Label();
            this.sNameTextBox = new System.Windows.Forms.TextBox();
            this.sNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manageTabControl.SuspendLayout();
            this.suppliersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supBindingNavigator)).BeginInit();
            this.supBindingNavigator.SuspendLayout();
            this.blockedSupTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockedDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
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
            this.suppliersTabPage.Controls.Add(this.searchTextBox);
            this.suppliersTabPage.Controls.Add(this.sortButton);
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
            this.suppliersTabPage.Leave += new System.EventHandler(this.suppliersTabPage_Leave);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(696, 6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(425, 35);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(7, 542);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(225, 63);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // suppliersGridView
            // 
            this.suppliersGridView.AllowUserToAddRows = false;
            this.suppliersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.suppliersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersGridView.Location = new System.Drawing.Point(6, 55);
            this.suppliersGridView.Name = "suppliersGridView";
            this.suppliersGridView.ReadOnly = true;
            this.suppliersGridView.RowTemplate.Height = 28;
            this.suppliersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.suppliersGridView.Size = new System.Drawing.Size(1121, 481);
            this.suppliersGridView.TabIndex = 1;
            this.suppliersGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersGridView_CellDoubleClick);
            // 
            // supBindingNavigator
            // 
            this.supBindingNavigator.AddNewItem = null;
            this.supBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.supBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.supBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
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
            this.supBindingNavigator.Location = new System.Drawing.Point(7, 6);
            this.supBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.supBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.supBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.supBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.supBindingNavigator.Name = "supBindingNavigator";
            this.supBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.supBindingNavigator.Size = new System.Drawing.Size(276, 31);
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
            this.blockedSupTabPage.Controls.Add(this.label1);
            this.blockedSupTabPage.Controls.Add(this.button1);
            this.blockedSupTabPage.Controls.Add(this.blockedDG);
            this.blockedSupTabPage.Controls.Add(this.bindingNavigator1);
            this.blockedSupTabPage.Location = new System.Drawing.Point(4, 29);
            this.blockedSupTabPage.Name = "blockedSupTabPage";
            this.blockedSupTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.blockedSupTabPage.Size = new System.Drawing.Size(1127, 711);
            this.blockedSupTabPage.TabIndex = 1;
            this.blockedSupTabPage.Text = "Blocked Suppliers";
            this.blockedSupTabPage.ToolTipText = "List of blocked suppliers";
            this.blockedSupTabPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // blockedDG
            // 
            this.blockedDG.AllowUserToAddRows = false;
            this.blockedDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.blockedDG.BackgroundColor = System.Drawing.SystemColors.Control;
            this.blockedDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blockedDG.Location = new System.Drawing.Point(3, 40);
            this.blockedDG.Name = "blockedDG";
            this.blockedDG.ReadOnly = true;
            this.blockedDG.RowTemplate.Height = 28;
            this.blockedDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.blockedDG.Size = new System.Drawing.Size(1121, 517);
            this.blockedDG.TabIndex = 2;
            this.blockedDG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.blockedDG_CellDoubleClick);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = this.toolStripButton1;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator3,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton2;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton5;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton4;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton3;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1121, 31);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 28);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "Delete";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "Move first";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton3.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 31);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton4.Text = "Move next";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton5.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
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
            this.saveSupButton.Location = new System.Drawing.Point(13, 210);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(430, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Double click to unlock";
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
            this.blockedSupTabPage.ResumeLayout(false);
            this.blockedSupTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockedDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.addSupplierTabPage.ResumeLayout(false);
            this.addSupplierTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl manageTabControl;
        private System.Windows.Forms.TabPage suppliersTabPage;
        private System.Windows.Forms.TabPage blockedSupTabPage;
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
        private System.Windows.Forms.DataGridView suppliersGridView;
        private System.Windows.Forms.DataGridView blockedDG;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
    }
}
