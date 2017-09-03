using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace TestFramework.Common
{
    public  static class Commonfield
    {
        public static void GeneralField()
        {
            Actions action = new Actions(Browser.Driver);
            action.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).SendKeys(Keys.Delete).Perform();
            Thread.Sleep(5000);
            IWebElement newwin1 = Browser.Driver.FindElement(By.Id("countryFormView"));
            newwin1.FindElement(By.Name("code")).Clear();
            newwin1.FindElement(By.Name("code")).SendKeys("197");
            newwin1.FindElement(By.Name("name_np")).SendKeys("had");
            newwin1.FindElement(By.Name("name_en")).SendKeys("had1");
            newwin1.FindElement(By.Name("display_order")).SendKeys("2");
            Thread.Sleep(3000);
            newwin1.FindElement(By.ClassName("fa-floppy-o")).Click();
            IWebElement newmodeokbutton1 = Browser.Driver.FindElement(By.Id("button-1014"));
            newmodeokbutton1.Click();
            ExplicitWait.WaitId("country-list-grid");
        }
    }
}
