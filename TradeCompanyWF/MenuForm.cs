using BussinessLogic.Interfaces;
using DTO;
using System.Windows.Forms;

namespace TradeCompanyWF
{
    public partial class MenuForm : Form
    {
        protected UserDTO _user;
        protected IEntityBL _entityBL;
        public MenuForm(IEntityBL entityBL, UserDTO user = null)
        {
            InitializeComponent();
            _user = user;
            _entityBL = entityBL;
        }
    }
}
