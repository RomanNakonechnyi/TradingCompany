using AutoMapper;
using BussinessLogic;
using BussinessLogic.Interfaces;
using DAL;
using DAL.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace TradeCompanyWF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static UnityContainer Container { get; set; }
        [STAThread]
        static void Main()
        {
            ConfigureUnity();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var loginForm = Container.Resolve<LoginForm>();
            Application.Run(loginForm);
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(Container.Resolve<MenuForm>());
            }
            else
            {
                Application.Exit();
            }
        }

        private static void ConfigureUnity()
        {
            Container = new UnityContainer();

            Container.RegisterType<IUserDAL, UserDAL>();
            Container.RegisterType<IProductDAL, ProductDAL>();
            Container.RegisterType<ISupplierProductDAL, SupplierProductDAL>();
            Container.RegisterType<ISupplierDAL, SupplierDAL>();
            Container.RegisterType<IEntityBL, EntityBL>();

            var config = new MapperConfiguration(c => c.AddProfiles(typeof(UserDAL).Assembly));
            Container.RegisterInstance(config.CreateMapper());
        }
    }
}
