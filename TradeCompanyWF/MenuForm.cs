using BussinessLogic.Interfaces;
using DTO;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace TradeCompanyWF
{
    public partial class MenuForm : Form
    {
        protected UserDTO _user;
        protected IEntityBL _entityBL;
        protected List<SupplierDTO> _suppiers;

        private UserControl profileControl;
        private Button button;

        public MenuForm(IEntityBL entityBL, UserDTO user = null)
        {
            InitializeComponent();
            _user = user;
            _entityBL = entityBL;
            profileControl = new ProfileControl(_user)
            {
                Location = new System.Drawing.Point(0, toolStrip1.Height)
            };
            button = new Button();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void ProfileButton_Click(object sender, System.EventArgs e)
        {
            button.Hide();
            MenuSplitContainer.Panel2.Controls.Add(profileControl);
            profileControl.Show();
        }

        private void ManageButton_Click(object sender, System.EventArgs e)
        {
            profileControl.Hide();
            MenuSplitContainer.Panel2.Controls.Add(button);
            button.Show();
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Hide();
            var loginForm = Program.Container.Resolve<LoginForm>();

            loginForm.ShowDialog();
        }
    }
}
