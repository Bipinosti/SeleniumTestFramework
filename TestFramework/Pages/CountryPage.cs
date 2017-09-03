using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using TestFramework.Common;

namespace TestFramework
{

    public class CountryPage
    {
        public void CanTestCode()
        {
            //TODO : code part
            ExplicitWait.WaitName("code");
            IWebElement code = ElementFinder.FindByName("code");
            ExplicitWait.WaitName("code");
            code.SendKeys(Keys.Enter);
            code.SendKeys("2");
            code.SendKeys(Keys.Enter);
            ExplicitWait.WaitName("code");
            code.Clear();
            code.SendKeys(Keys.Enter);
            ExplicitWait.WaitId("country-list-grid");

            //TODO: View form detail
            IWebElement grid2 = ElementFinder.FindById("country-list-grid");
            Thread.Sleep(1500);
            IWebElement viewIcon = grid2.FindElements(By.ClassName("fa-eye"))[1];
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)Browser.Driver;
            js2.ExecuteScript("arguments[0].click();", viewIcon);
            IWebElement viewwin = ElementFinder.FindById("countryFormView");
            Thread.Sleep(7000);
            IWebElement Closebutton = ElementFinder.FindById("cancel-button");
            Closebutton.Click();

            //TODO :New Form
            Commonfield.GeneralField();
           

            //TODO : Edit form 
            code.SendKeys(Keys.Enter);
            Thread.Sleep(1500);
            IWebElement EditIcon = grid2.FindElements(By.ClassName("fa-pencil-square-o"))[1];
            js2.ExecuteScript("arguments[0].click();", EditIcon);
            IWebElement Editwin = ElementFinder.FindById("countryFormView");
            ExplicitWait.WaitName("code");
            Editwin.FindElement(By.Name("description")).SendKeys("8");
            Editwin.FindElement(By.ClassName("fa-floppy-o")).Click();
            IWebElement Editokbutton1 = Browser.Driver.FindElement(By.Id("button-1014"));
            Editokbutton1.Click();
            ExplicitWait.WaitId("country-list-grid");

            //TODO Delete form
            code.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            IWebElement deleteicon = grid2.FindElements(By.ClassName("fa-trash-o"))[1];
            deleteicon.Click();
            IWebElement deleteokbutton = Browser.Driver.FindElement(By.Id("button-1014-btnWrap"));
            Thread.Sleep(3000);
            deleteokbutton.Click();
            Thread.Sleep(15000);
        }
    }

}