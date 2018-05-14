using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
namespace AnswerFrameworkTests.Core.Helpers
{
    public class PageObjectHelpers : IPageObjectHelpers
    {
        public IWebDriver Driver;
        public IJavaScriptExecutor Js;
        public WebDriverWait Wait;

        public PageObjectHelpers(IWebDriver driver)
        {
            Driver = driver;
            Js = (IJavaScriptExecutor)driver;
            Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 0, 20, 0));
        }

        public IReadOnlyCollection<IWebElement> SearchElementsByCss(string cssSelector)
        {
            try
            {
#pragma warning disable CS0618 // Type or member is obsolete
                return Wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector(cssSelector)));
#pragma warning restore CS0618 // Type or member is obsolete
            }
            catch
            {
                return null;
            }
        }

        public IWebElement SearchElementByCss(string cssSelector)
        {
            try
            {

#pragma warning disable CS0618 // Type or member is obsolete
                return Wait.Until(condition:ExpectedConditions.ElementToBeClickable(By.CssSelector(cssSelector)));
#pragma warning restore CS0618 // Type or member is obsolete
            }

            catch
            {
                return null;
            }
        }     

        public IWebElement WaitByClassUntilTextContains(string classname, string text)
        {
            Wait.Until(d => d.FindElement(By.ClassName(classname)).Text.Contains(text));
            return Wait.Until(d => d.FindElement(By.ClassName(classname)));
        }

        public IWebElement WaitByLinkTextContains(string text)
        {
            Wait.Until(d => d.FindElement(By.LinkText(text)));
            return Wait.Until(d => d.FindElement(By.LinkText(text)));
        }

        public IWebDriver GetDriver()
        {
            return Driver;
        }
       
    }
}
