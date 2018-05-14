using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace AnswerFrameworkTests.Core.Helpers
{
    public class TestCaseHelpers : ITestCaseHelpers
    {
        public IWebDriver Driver;
        public IJavaScriptExecutor Js;
        public WebDriverWait Wait;
        public Actions Action;
        private static readonly Stopwatch Timer = new Stopwatch();


        public TestCaseHelpers(IWebDriver driver)
        {
            Driver = driver;
            Js = (IJavaScriptExecutor)driver;
            Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 0, 20, 0));
            Action = new Actions(driver);
        }

        public string Browser()
        {
            return ((RemoteWebDriver)Driver).Capabilities.BrowserName;
        }
        public void RefreshPage()
        {
            Driver.Navigate().Refresh();
        }

        public void GoToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

       
        public bool IsAtUrl(string url)
        {
            return Driver.Url.Equals(url);
        }

       
       
    }
}

