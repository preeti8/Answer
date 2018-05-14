using System.Collections.Generic;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AnswerFrameworkTests.Core.Helpers
{
    public interface IPageObjectHelpers
    {
        IReadOnlyCollection<IWebElement> SearchElementsByCss(string cssSelector);
        IWebElement SearchElementByCss(string cssSelector);
        IWebElement WaitByClassUntilTextContains(string classname, string text);
        IWebElement WaitByLinkTextContains(string text);

        IWebDriver GetDriver();

    }
}

