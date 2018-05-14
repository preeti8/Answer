using Microsoft.Practices.Unity;
using AnswerFrameworkTests.Core.Helpers;
using AnswerFrameworkTests.PageObjects;
using AnswerFrameworkTests.PageObjects.Implementation;
using AnswerFrameworkTests.PageObjects.Interface;
using OpenQA.Selenium;
using Unity;
using Unity.Injection;

namespace AnswerFrameworkTests.Core
{
    public class SeleniumDependencyInstaller
    {
        public void Install(IUnityContainer container, IWebDriver driver)
        {
            container.RegisterType<ITestCaseHelpers, TestCaseHelpers>(new InjectionConstructor(driver));
            container.RegisterType<IPageObjectHelpers, PageObjectHelpers>(new InjectionConstructor(driver));


            container.RegisterType<IContactForm, ContactForm>();
            container.RegisterType<IWhoAreWe, WhoAreWe>();

        }
    }
}