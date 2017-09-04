using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;
using TestFramework.Common;

namespace TestFramework
{

    public class CountryPage
    {
        [FindsBy(How = How.Name, Using = "code")]
        private IWebElement code { get; set; }
        public void CanTestCode()
        {
            //TODO : code part
            Commonfield.CodeTest();

            //TODO: View form detail
            

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
            Commonfield.DeletePart();
        }
    }

}