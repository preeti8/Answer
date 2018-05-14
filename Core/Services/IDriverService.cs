using AnswerFrameworkTests.Services;
using OpenQA.Selenium;

namespace AnswerFrameworkTests.Core.Services
{
    public interface IDriverService
    {
        IWebDriver GetDriver(Enums.Drivers driverToUse);
    }
}

