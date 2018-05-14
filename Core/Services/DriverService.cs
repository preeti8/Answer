using System;
using AnswerFrameworkTests.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace AnswerFrameworkTests.Core.Services
{
    public class DriverService : IDriverService
    {
        public IWebDriver GetDriver(Enums.Drivers driverToUse)
        {
            IWebDriver theDriver;
            switch (driverToUse)
            {
                case Enums.Drivers.Chrome:
                    theDriver = new ChromeDriver();
                    break;
                case Enums.Drivers.Firefox:
                    theDriver = new FirefoxDriver();
                    break;
                case Enums.Drivers.InternetExplorer:
                    theDriver = new InternetExplorerDriver(new InternetExplorerOptions() { EnsureCleanSession = true });
                    break;
                default:
                    theDriver = new ChromeDriver();
                    break;
            }
            
           theDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromMilliseconds(10);
            theDriver.Manage().Window.Maximize();
            return theDriver;
        }
    }
}
