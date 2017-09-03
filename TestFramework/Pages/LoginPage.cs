using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using TestFramework.Generators;

namespace TestFramework
{
    public class LoginPage
    {

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitButton")]
        private IWebElement btnLogin { get; set; }

        public void Login()
        {
            var select = Browser.Driver.FindElement(By.Id("client_id"));
            var selectelement = new SelectElement(select);
            selectelement.SelectByIndex(2);
            var user = UserGenerator.Generate();
            txtUserName.SendKeys(user.Username);
            txtPassword.SendKeys(user.Password);
            btnLogin.Click();
           
        }

    }
}