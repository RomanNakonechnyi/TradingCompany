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

namespace TradeCompanyWF.UserControls
{
    public partial class manageContol : UserControl
    {
        private bool _isClicked = false;
        public manageContol(List<SupplierDTO> suppliers)
        {
            InitializeComponent();
            UpdateGrid(suppliers);
        }

        private void UpdateGrid(List<SupplierDTO> suppliers)
        {
            BindingList<SupplierDTO> bindingList = new BindingList<SupplierDTO>(suppliers);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = bindingList;

            suppliersGridView.DataSource = bindingSource;
            supBindingNavigator.BindingSource = bindingSource;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void saveSupButton_Click(object sender, EventArgs e)
        {
            if (ValidateEntries())
            {
                _isClicked = true;
                var sup = new SupplierDTO()
                {
                    name = sNameTextBox.Text,
                    isOrganization = SetOrganizationFromString(isCompanyComboBox.Text),
                    rating = (int)ratingNumericUpDown.Value,
                    isBlocked = false
                };

                Program.entityBL.AddSupplier(sup);
            }
        }



        private void addSupplierTabPage_Leave(object sender, EventArgs e)
        {
            //    if (!_isClicked && !ValidateEntries())
            //    {
            //        var result = MessageBox.Show("Are you sure ? New supplier will not be added!", "Attention!", MessageBoxButtons.OKCancel);
            //        if (result == DialogResult.OK)
            //        {
            //            sNameTextBox.Text = "";
            //            isCompanyComboBox.Text = "";
            //            ratingNumericUpDown.Value = default(decimal);
            //        }
            //    };
            //    _isClicked = false;
        }

        private bool ValidateEntries()
        {
            return isCompanyComboBox.Text != String.Empty
                && !String.IsNullOrWhiteSpace(sNameTextBox.Text)
                && ratingNumericUpDown.Value != default(decimal);
        }

        private bool? SetOrganizationFromString(string text)
        {
            bool isOrganization = false;
            switch (text)
            {
                case "Yes":
                    isOrganization = true;
                    break;
                case "No":
                    isOrganization = false;
                    break;
                default:
                    break;
            }
            return isOrganization;
        }

        private void manageTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            
            if (!_isClicked && !ValidateEntries())
            {
                if (e.TabPage == blockedSupTabPage || e.TabPage == suppliersTabPage)
                {
                    var result = MessageBox.Show("Are you sure ? New supplier will not be added!", "Attention!", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        sNameTextBox.Text = "";
                        isCompanyComboBox.Text = "";
                        ratingNumericUpDown.Value = default(decimal);
                    }

                    else
                    {
                        e.Cancel = true;
                    }
                };
                _isClicked = false;
            }
        }
    }
}
