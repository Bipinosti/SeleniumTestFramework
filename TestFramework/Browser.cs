using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TestFramework.Common;

namespace TestFramework
{
    public static class Browser
    {
        private static string baseUrl = "http://muntax.shangrilagroup.com.np/";
        public static IWebDriver webDriver = new ChromeDriver();
        public static void Initialize()
        {
            Goto("");
            Pages.Login.Login();
        }

        public static IWebDriver Driver
        {
            get { return webDriver; }
        }


        public static void Goto(string url)
        {
            System.Threading.Thread.Sleep(1000);
            webDriver.Url = baseUrl + url;
        }


    }
}
