using System;
using System.Windows.Forms;
using BussinessLogic.Interfaces;
using Task1.Helpers;
using Unity;
using Unity.Resolution;

namespace TradeCompanyWF
{
    public partial class LoginForm : Form
    {
        protected IEntityBL _entityBL;
        public LoginForm(IEntityBL entityBL)
        {
            InitializeComponent();
            _entityBL = entityBL;
            loginTextBox.Text = "admin";
            pswrdTextBox.Text = "admin";

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(loginTextBox.Text) || String.IsNullOrWhiteSpace(pswrdTextBox.Text))
            {
                MessageBox.Show("You must enter password and login", "Warning!!!");
                loginTextBox.Text = String.Empty;
                pswrdTextBox.Text = String.Empty;
                return;
            }
            var password = EncryptionHelper.Encrypt(pswrdTextBox.Text);
            var user = _entityBL.ValidateLogin(loginTextBox.Text, password);
            if(user != null)
            {
                var menu = Program.Container.Resolve<MenuForm>(new ParameterOverride("user",user));
                Hide();
                menu.ShowDialog();
                //Application.Run(menu);
                
                return;
            }
            MessageBox.Show("Incorrect password or login!!!", "Error");
        }
    }
}
