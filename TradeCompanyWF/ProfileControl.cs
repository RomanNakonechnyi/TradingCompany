using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace TradeCompanyWF
{
    public partial class ProfileControl : UserControl
    {
        private UserDTO _user;

        public ProfileControl()
        {
            InitializeComponent();
        }

        public ProfileControl(UserDTO user)
        {
            InitializeComponent();
            _user = user;
            nameTextBox.Text = _user.fullName;
            phoneTextBox.Text = _user.phoneNumber;
            emailTextBox.Text = _user.eMail;
            genderComboBox.Text = GetGender(_user);
        }

        private string GetGender(UserDTO user)
        {
            if(user.isFemale != true)
            {
                return "Male";
            }
            return "Male";
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (sender as ComboBox).SelectedItem.ToString();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            _user.fullName = nameTextBox.Text;
            _user.phoneNumber = phoneTextBox.Text;
            _user.eMail = emailTextBox.Text;
            _user.isFemale = SetGenderFromString(genderComboBox.Text);

            Program.entityBL.UpdateUser(_user);
            
        }

        private bool? SetGenderFromString(string text)
        {
            bool isFemale = false;
            switch(text)
            {
                case "Female":
                    isFemale = true;
                    break;
                case "Male":
                    isFemale = false;
                    break;
                default:
                    break;
            }
            return isFemale;
        }
    }
}
