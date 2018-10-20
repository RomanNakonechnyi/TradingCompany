using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradeCompanyDAL;
using Task1.BL;
using Task1.Helpers;

namespace TradeCompanyWF
{
    public partial class LoginForm : Form
    {
        UserDAL userDAL = new UserDAL();
        public LoginForm()
        {
            InitializeComponent();
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
            var user = LoginBL.ValidateLogin(loginTextBox.Text, password);
            if(user != null)
            {
                MessageBox.Show("Congratulate");
                return;
            }
            MessageBox.Show("Incorrect password or login!!!", "Error");
        }
    }
}
