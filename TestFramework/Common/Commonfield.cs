using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace TestFramework.Common
{
   
    public class Commonfield
    {
        [FindsBy(How = How.Name, Using = "code")]
        private static IWebElement code { get; set; }
        public static void CodeTest()
        {
            ExplicitWait.WaitName("code");
            //IWebElement code = ElementFinder.FindByName("code");            ExplicitWait.WaitName("code");
            code.SendKeys(Keys.Enter);
            code.SendKeys("2");
            code.SendKeys(Keys.Enter);
            ExplicitWait.WaitName("code");
            code.Clear();
            code.SendKeys(Keys.Enter);
            ExplicitWait.WaitId("country-list-grid");
        }
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

        public static void DeletePart()
        {
            
            IWebElement code = ElementFinder.FindByName("code");
            code.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            IWebElement grid2 = ElementFinder.FindById("country-list-grid");
            IWebElement deleteicon = grid2.FindElements(By.ClassName("fa-trash-o"))[1];
            deleteicon.Click();
            IWebElement deleteokbutton = Browser.Driver.FindElement(By.Id("button-1014-btnWrap"));
            Thread.Sleep(3000);
            deleteokbutton.Click();
            Thread.Sleep(15000);
        }
        public static void View()
        {
            IWebElement grid2 = ElementFinder.FindById("country-list-grid");
            Thread.Sleep(1500);
            IWebElement viewIcon = grid2.FindElements(By.ClassName("fa-eye"))[1];
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)Browser.Driver;
            js2.ExecuteScript("arguments[0].click();", viewIcon);
            IWebElement viewwin = ElementFinder.FindById("countryFormView");
            Thread.Sleep(7000);
            IWebElement Closebutton = ElementFinder.FindById("cancel-button");
            Closebutton.Click();
        }
    }
}
