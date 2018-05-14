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
        internal class ContactFormTest : StartUp
        {

            private IContactForm contactForm { get; set; }

            
            [SetUp]
            public void TestSetUp()
            {
            contactForm = Container.Resolve<IContactForm>();
               
            }

            [Test]
             [StartUpInfo( Brands.Default)]
            public void Send_query_on_empty_form_assert_validation_messages()
            {
            VisitSite();
            Assert.That(contactForm.IsVisible(), Is.EqualTo(true));
            contactForm.ClickContactForm();
           Assert.That(contactForm.IsPageVisible(), Is.EqualTo(true));
           contactForm.ClickSendButton();

           // Assert.That(contactForm.IsValidationShowing(), Is.EqualTo("Fullname is required"));
            //Assert.That(contactForm.GetValidationDetails("Email is required"), Is.EqualTo(true));
            //Assert.That(contactForm.GetValidationDetails("Contact is required"), Is.EqualTo(true));
            //Assert.That(contactForm.GetValidationDetails("Chosen contact is Invalid"), Is.EqualTo(true));

        }
    }
    }


        /*[Test]
        [StartUpInfo(Users.Default, Brands.DevReporting)]
        public void When_entering_search_text_with_varying_lengths_suitable_warning_messages_should_appear_as_well_as_having_no_types()
        {
            Login();
            Search.ClickSearch();
            Assert.That(Search.IsCharWarningShowing(), Is.EqualTo(true));
            Search.SearchPage("B");
            Assert.That(Search.IsCharWarningShowing(), Is.EqualTo(true));
            Search.SearchPage("MS");
            Assert.That(Search.IsCharWarningNotShowing(), Is.EqualTo(true));
            Search.SearchtermBackspace();
            Assert.That(Search.IsCharWarningShowing(), Is.EqualTo(true));
            Assert.That(Search.IsEnabled(), Is.EqualTo(false));
            Search.SearchPage("S");
            Assert.That(Search.IsEnabled(), Is.EqualTo(true));
            Assert.That(Search.IsCharWarningNotShowing(), Is.EqualTo(true));
            Search.ClickSearchButton();
            Assert.That(Search.IsTypeWarningShowing(), Is.EqualTo(true));
            Search.SelectSearchTypeByFirst();
            Search.ClickSearchButton();
            Assert.That(Search.IsTypeWarningNotShowing(), Is.EqualTo(true));
        }

        [Test]
        [StartUpInfo(Users.Default, Brands.DevReporting)]
        public void I_can_choose_the_search_type_in_the_dialogue_box_and_it_brings_back_correct_results()
        {
            Login();
            Search.ClickSearch();
            Search.SearchPage("Selenium S");
            Search.SelectSearchTypeByFirst();
            Search.SelectSearchTypeByOrder(2);
            Assert.That(Search.SearchTypeContains("Business Unit"), Is.EqualTo(true));
            Assert.That(Search.SearchTypeContains("Site"), Is.EqualTo(true));
            TestCaseHelpers.AssertTime(Search.ClickSearchButton, 3000, "Results took");
            Assert.That(Search.SearchResultCount(), Is.EqualTo(2));
            Search.RemoveSearchTypeByName("Site");
            Assert.That(Search.SearchTypeContains("Business Unit"), Is.EqualTo(true));
            Assert.That(Search.SearchTypeContains("Site"), Is.EqualTo(false));
            TestCaseHelpers.AssertTime(Search.ClickSearchButton, 3000, "Results took");
            Assert.That(Search.SearchResultCount(
            */
