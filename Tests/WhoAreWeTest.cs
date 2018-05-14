using Microsoft.Practices.Unity;
using AnswerFrameworkTests.Core;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using AnswerFrameworkTests.PageObjects.Interface;
using AnswerFrameworkTests.Core.Attributes;
using OpenQA.Selenium;
using Brands = AnswerFrameworkTests.Services.Enums.Brands;
using Unity;

namespace AnswerFrameworkTests.Tests
{
    internal class WhoAreWe : StartUp
    {

        private IWhoAreWe Whoarewe { get; set; }

        [SetUp]
        public void TestSetUp()
        {
            Whoarewe = Container.Resolve<IWhoAreWe>();
            //Node = Container.Resolve<INode>();
        }

        [Test]
        [StartUpInfo(Brands.Default)]
        public void Assert_values_of_the_company()
        {
            VisitSite();
            Assert.That(Whoarewe.IsVisible(), Is.EqualTo(true));
            Whoarewe.ClickWhoAreWe();
            Assert.That(Whoarewe.IsPageVisible(), Is.EqualTo(true));
           
        }

    }
    }



