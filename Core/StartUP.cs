using System;
using System.Diagnostics;
using Microsoft.Practices.Unity;
using AnswerFrameworkTests.Core.Helpers;
using AnswerFrameworkTests.Core.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using Unity;
using DriverService = AnswerFrameworkTests.Core.Services.DriverService;

namespace AnswerFrameworkTests.Core
{
    public class StartUp
    {
        private static IWebDriver _driver;

        public static ITestCaseHelpers TestCaseHelpers;

        public static IPageObjectHelpers PageObjectHelpers;

        public UnityContainer Container = new UnityContainer();

        [SetUp]
        public void Initialize()
        {
            _driver = new DriverService().GetDriver(CustomAttributes.GetDriverType(new StackTrace().GetFrame(1).GetMethod()));
            new SeleniumDependencyInstaller().Install(Container, _driver);

            TestCaseHelpers = Container.Resolve<ITestCaseHelpers>();
            PageObjectHelpers = Container.Resolve<IPageObjectHelpers>();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }


        public static void VisitSite()
        {
            var Data = CustomAttributes.GetStartUpInfo(new StackTrace().GetFrame(1).GetMethod());

            if (Data.SiteUrl != "")
            {
                TestCaseHelpers.GoToUrl(Data.SiteUrl);
            }
        }

        public void Dispose()
        {
            Container.Dispose();
        }

    }
}