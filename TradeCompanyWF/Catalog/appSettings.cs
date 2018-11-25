namespace TradeCompanyWF.Catalog
{
    public class AppSettings
    {
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public static string UserLoginPropertyName = nameof(UserLogin);
        public static string UserPasswordPropertyName = nameof(UserPassword);
    }
}
