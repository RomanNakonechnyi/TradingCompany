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
        public static UnityContainer Container { get; set; }
        public static Catalog.AppSettingsManager AppSettingsManager { get; set; }
        public static IEntityBL entityBL;

        [STAThread]
        static void Main()
        {
            entityBL = new EntityBL();
            AppSettingsManager = new Catalog.AppSettingsManager();
            ConfigureUnity();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var loginForm = Container.Resolve<LoginForm>();
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
