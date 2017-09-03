using System;
using OpenQA.Selenium;

namespace TestFramework.Common
{
    public interface IElementFinder
    {
        IWebElement GetById(string id);
        IWebElement GetByName(string name);
        IWebElement GetByClass(string className);
    }
    public  class ElementFinder 
    {
        static IElementFinder init = new ElementInitializer();
        public static IWebElement FindById(string id)
        {
           return init.GetById(id);
        }

        public static IWebElement FindByName(string name)
        {
            return init.GetByName(name);
        }
        public static IWebElement FindByClass(string className)
        {
            return init.GetByClass(className);
        }

    }

    public class ElementInitializer : IElementFinder
    {
        private IWebElement _webElement;
        //public ElementInitializer(IWebElement webElement)
        //{
        //    _webElement = webElement;
        //}
        public IWebElement InitElement(By by)
        {

            _webElement =  Browser.Driver.FindElement(by);
            if (_webElement != null)
            {
                return _webElement;
            }
            return null;
        }

        public  IWebElement GetById(string id)
        {
            var element = InitElement(By.Id(id));
            if (element != null)
            {
                return element;
            }
            return null;
        }

        public IWebElement GetByName(string name)
        {
            var element =  InitElement(By.Name(name));
            if (element != null)
            {
                return element;
            }
            return null;
        }

        public IWebElement GetByClass(string className)
        {
            var element = InitElement(By.ClassName(className));
            if (element != null)
            {
                return element;
            }
            return null;
        }
    }
}
