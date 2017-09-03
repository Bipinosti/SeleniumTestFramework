using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestFramework.Common
{
    public class ExplicitWait
    {
        public static void WaitName(string locationName)
        {
            WebDriverWait wait = new WebDriverWait(Browser.webDriver, TimeSpan.FromSeconds(1000));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy((By.Name(locationName))));
        }
        public static void WaitId(string locationName)
        {
            WebDriverWait wait = new WebDriverWait(Browser.webDriver, TimeSpan.FromSeconds(1000));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy((By.Id(locationName))));
        }
    }
}
