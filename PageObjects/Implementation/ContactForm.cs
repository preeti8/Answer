using System.Linq;
using System.Threading;
using System.Collections.Generic;
using AnswerFrameworkTests.Core.Helpers;
using AnswerFrameworkTests.PageObjects.Interface;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AnswerFrameworkTests.PageObjects.Implementation
{
    public class ContactForm : IContactForm
    {
        private readonly IPageObjectHelpers _pageObjectHelpers;
        private readonly IJavaScriptExecutor _js;

        public ContactForm(IPageObjectHelpers pageObjectHelpers)
        {
            _pageObjectHelpers = pageObjectHelpers;
            _js = (IJavaScriptExecutor)_pageObjectHelpers.GetDriver();
        }

        public bool IsVisible()
        {
            var contact = _pageObjectHelpers.SearchElementsByCss("#topNavMenu");
            return contact != null && contact.First().Displayed;
        }

        public void ClickContactForm()
        {
            var search = _pageObjectHelpers.WaitByLinkTextContains("Contact Us");
            search?.Click();
        }

        public bool IsPageVisible()
        {
            var contact = _pageObjectHelpers.SearchElementsByCss("#tdtop");
            return contact != null && contact.First().Displayed;
        }

        public void ClickSendButton()
        {
            var searchButton = _pageObjectHelpers.SearchElementsByCss("input[type = 'submit']").First();
            searchButton.SendKeys(Keys.Enter);


        }
        //public bool IsValidationShowing()
        //{
        //    var passwordBox = _pageObjectHelpers.SearchElementsByCss("#tdtop");
        //    var warning = passwordBox.First().FindElement(By.XPath("/../../../.."));
        //    return warning.Displayed;
        //}
    }

    }
    
    

        

