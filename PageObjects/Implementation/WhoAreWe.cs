using System.Linq;
using System.Threading;
using System.Collections.Generic;
using AnswerFrameworkTests.Core.Helpers;
using AnswerFrameworkTests.PageObjects.Interface;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AnswerFrameworkTests.PageObjects.Implementation
{
    public class WhoAreWe : IWhoAreWe
    {
        private readonly IPageObjectHelpers _pageObjectHelpers;
        private readonly IJavaScriptExecutor _js;

        public WhoAreWe(IPageObjectHelpers pageObjectHelpers)
        {
            _pageObjectHelpers = pageObjectHelpers;
            _js = (IJavaScriptExecutor)_pageObjectHelpers.GetDriver();
        }

        public bool IsVisible()
        {
            var contact = _pageObjectHelpers.SearchElementsByCss("#topNavMenu");
            return contact != null && contact.First().Displayed;
        }

        public void ClickWhoAreWe()
        {
            var search = _pageObjectHelpers.WaitByLinkTextContains("Who are we");
            //search?.First().Click();
            search?.Click();
        }

        public bool IsPageVisible()
        {
            var contact = _pageObjectHelpers.SearchElementsByCss("#tdtop");
            return contact != null && contact.First().Displayed;
        }

       
    }
}