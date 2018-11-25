using System;
using System.Windows.Forms;

namespace TradeCompanyWF
{
    partial class MenuForm
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.MenuSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ManageButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSplitContainer)).BeginInit();
            this.MenuSplitContainer.Panel1.SuspendLayout();
            this.MenuSplitContainer.Panel2.SuspendLayout();
            this.MenuSplitContainer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuSplitContainer
            // 
            this.MenuSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuSplitContainer.IsSplitterFixed = true;
            this.MenuSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MenuSplitContainer.Name = "MenuSplitContainer";
            // 
            // MenuSplitContainer.Panel1
            // 
            this.MenuSplitContainer.Panel1.Controls.Add(this.ManageButton);
            this.MenuSplitContainer.Panel1.Controls.Add(this.ProfileButton);
            // 
            // MenuSplitContainer.Panel2
            // 
            this.MenuSplitContainer.Panel2.Controls.Add(this.toolStrip1);
            this.MenuSplitContainer.Size = new System.Drawing.Size(1057, 573);
            this.MenuSplitContainer.SplitterDistance = 200;
            this.MenuSplitContainer.TabIndex = 0;
            // 
            // ManageButton
            // 
            this.ManageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManageButton.Location = new System.Drawing.Point(0, 59);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(200, 59);
            this.ManageButton.TabIndex = 2;
            this.ManageButton.Text = "Manage";
            this.ManageButton.UseVisualStyleBackColor = true;
            this.ManageButton.Click += new System.EventHandler(this.ManageButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileButton.Location = new System.Drawing.Point(0, 0);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(200, 59);
            this.ProfileButton.TabIndex = 0;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(853, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(81, 29);
            this.toolStripButton1.Text = "Log Out";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MenuForm
            // 
            this.ClientSize = new System.Drawing.Size(1057, 573);
            this.Controls.Add(this.MenuSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.MenuSplitContainer.Panel1.ResumeLayout(false);
            this.MenuSplitContainer.Panel2.ResumeLayout(false);
            this.MenuSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSplitContainer)).EndInit();
            this.MenuSplitContainer.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer MenuSplitContainer;
        private Button ProfileButton;
        private Button ManageButton;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
    }
}