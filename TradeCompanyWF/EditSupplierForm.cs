using DTO;
using System.ComponentModel;
using System.Windows.Forms;

namespace TradeCompanyWF
{
    public partial class EditSupplierForm : Form
    {
        private SupplierDTO _supplier;

        public EditSupplierForm(SupplierDTO supplier)
        {
            _supplier = supplier;
            InitializeComponent();

            sNameTextBox.Text = supplier.name;
            isCompanyComboBox.Text = GetIsOrg(supplier);
            rNumDrop.Value = supplier.rating;
            blockCheckBox.Checked = supplier.isBlocked;
        }

        private void HandleTextValidaiton(TextBox txt, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                toolTip1.Show("Please enter text", txt, 5000);
                e.Cancel = true;
            }
        }

        private void buttonOk_Click(object sender, System.EventArgs e)
        {
            if (this.ValidateChildren())
            {
                _supplier.name = sNameTextBox.Text;
                _supplier.isOrganization = SetOrgFromString(isCompanyComboBox.Text);
                _supplier.rating = (int)rNumDrop.Value;
                _supplier.isBlocked = blockCheckBox.Checked;
                Program.entityBL.UpdateSupplier(_supplier);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {

        }
        private bool SetOrgFromString(string text)
        {
            bool isOrg = false;
            switch (text)
            {
                case "Yes":
                    isOrg = true;
                    break;
                case "No":
                    isOrg = false;
                    break;
                default:
                    break;
            }
            return isOrg;
        }

        private string GetIsOrg(SupplierDTO supplier)
        {
            if (supplier.isOrganization != true)
            {
                return "No";
            }
            return "Yes";
        }
    }
}
