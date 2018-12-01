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
using Unity;
using Unity.Resolution;

namespace TradeCompanyWF.UserControls
{
    public partial class manageContol : UserControl
    {
        private List<SupplierDTO> _suppliers;
        private List<SupplierDTO> _blockedSuppliers;
        public manageContol(List<SupplierDTO> suppliers)
        {
            InitializeComponent();
            UpdateGrid(suppliers);
        }

        private void UpdateGrid(List<SupplierDTO> suppliers)
        {
            _suppliers = suppliers;

            BindingList<SupplierDTO> bindingList = new BindingList<SupplierDTO>(_suppliers);

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
                var sup = new SupplierDTO()
                {
                    name = sNameTextBox.Text,
                    isOrganization = SetOrganizationFromString(isCompanyComboBox.Text),
                    rating = (int)ratingNumericUpDown.Value,
                    isBlocked = false
                };

                Program.entityBL.AddSupplier(sup);
            }
            else
            {
                MessageBox.Show("Check data", "Error!", MessageBoxButtons.OK);
            }
        }



        private void addSupplierTabPage_Leave(object sender, EventArgs e)
        {
            _suppliers = Program.entityBL.GetSuppliers();
            UpdateGrid(_suppliers);
        }

        private bool ValidateEntries()
        {
            return isCompanyComboBox.Text != String.Empty
                && !String.IsNullOrWhiteSpace(sNameTextBox.Text);
                
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
            //if (!_isClicked && !ValidateEntries())
            //{
            //    var result = MessageBox.Show("Are you sure ? New supplier will not be added!", "Attention!", MessageBoxButtons.OKCancel);
            //    if (result == DialogResult.OK)
            //    {
            //        sNameTextBox.Text = "";
            //        isCompanyComboBox.Text = "";
            //        ratingNumericUpDown.Value = default(decimal);
            //    }

            //    else
            //    {
            //        e.Cancel = true;
            //    }
            //    _isClicked = false;
            //}
        }

        private void suppliersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditSupplierForm editSup = Program.Container.Resolve<EditSupplierForm>
                (
                    new ParameterOverride("supplier", _suppliers[e.RowIndex])
                );
            if (editSup.ShowDialog() == DialogResult.OK)
            {
                _suppliers = Program.entityBL.GetSuppliers();
                UpdateGrid(_suppliers);
            }
            else
            {
                MessageBox.Show("No changes were made");
            };
            
        }

        private void suppliersTabPage_Leave(object sender, EventArgs e)
        {
            _blockedSuppliers = Program.entityBL.GetBlockedSuppliers();
            UpdateBlockedSuppliers(_blockedSuppliers);
        }

        private void UpdateBlockedSuppliers(List<SupplierDTO> blockedSuppliers)
        {
            _blockedSuppliers = blockedSuppliers;
            BindingList<SupplierDTO> bindingList = new BindingList<SupplierDTO>(_blockedSuppliers);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = bindingList;

            blockedDG.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }

        private void blockedDG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var result = MessageBox.Show("Are you sure to unblock this supplier?", "Attention", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Program.entityBL.UnblockById(_blockedSuppliers[e.RowIndex].supplierId);
                _blockedSuppliers = Program.entityBL.GetBlockedSuppliers();
                UpdateBlockedSuppliers(_blockedSuppliers);
                _suppliers = Program.entityBL.GetSuppliers();
                UpdateGrid(_suppliers);
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            var sorted = Program.entityBL.SortSuppliers(_suppliers,1);
            UpdateGrid(sorted);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sorted = _blockedSuppliers.OrderBy(s => s.name).ToList();
            UpdateBlockedSuppliers(sorted);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var finded = Program.entityBL.GetSupplierByName(searchTextBox.Text);
            UpdateGrid(finded);
        }
    }
}
