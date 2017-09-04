using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }
        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }
        public static CountryPage Country
        {
            get { return GetPage<CountryPage>(); }
        }

    }
}
