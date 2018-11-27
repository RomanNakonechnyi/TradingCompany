using BussinessLogic.Interfaces;
using DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TradeCompanyWF.UserControls;
using Unity;

namespace TradeCompanyWF
{
    public partial class MenuForm : Form
    {
        #region Private and protected fields
        protected UserDTO _user;
        protected IEntityBL _entityBL;
        protected List<SupplierDTO> _suppliers;

        private UserControl _profileControl;
        private UserControl _manageControl;
        #endregion

        #region Constructor
        public MenuForm(IEntityBL entityBL, UserDTO user = null)
        {
            InitializeComponent();
            InitializeFields(entityBL, user);
            InitializeMenuForm(entityBL, user);
        }



        #endregion

        #region Private methods
        private void InitializeFields(IEntityBL entityBL, UserDTO user)
        {
            _user = user;
            _entityBL = entityBL;
            _suppliers = _entityBL.GetSuppliers();
        }

        private void InitializeMenuForm(IEntityBL entityBL, UserDTO user)
        {
            _profileControl = new ProfileControl(_user)
            {
                Location = new System.Drawing.Point(0, toolStrip1.Height)
            };
            _manageControl = new manageContol(_suppliers)
            {
                Location = new System.Drawing.Point(0, toolStrip1.Height)
            };

            MenuSplitContainer.Panel2.Controls.Add(_profileControl);
            MenuSplitContainer.Panel2.Controls.Add(_manageControl);
            _manageControl.Hide();
        }

        private void ProfileButton_Click(object sender, System.EventArgs e)
        {
            _manageControl.Hide();
            _profileControl.Show();
        }

        private void ManageButton_Click(object sender, System.EventArgs e)
        {
            _profileControl.Hide();
            _manageControl.Show();
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Hide();
            var loginForm = Program.Container.Resolve<LoginForm>();

            loginForm.ShowDialog();
        }
        #endregion

        private void MenuSplitContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
