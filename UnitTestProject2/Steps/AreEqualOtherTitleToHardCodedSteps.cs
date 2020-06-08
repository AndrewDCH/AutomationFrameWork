using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject2
{
    [Binding]
    public class AreEqualOtherTitleToHardCodedSteps
    {

        private IWebDriver _driver;

        public AreEqualOtherTitleToHardCodedSteps()
        {
            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");

        }

        [Given(@"I go to BBC homepage")]
        public void GivenIGoToBBCHomepage()
        {
            HomePage home = new HomePage(_driver);
            home.GoToBBC();
        }
        
        [When(@"I click on News button")]
        public void WhenIClickOnNewsButton()
        {
            HomePage home = new HomePage(_driver);
            home.ClickNews();
        }
        
        [Then(@"compare are equal secondary titles to hardcoded list")]
        public void ThenCompareAreEqualSecondaryTitlesToHardcodedList()
        {
            NewsPage news = new NewsPage(_driver);
            news.AreEqualOtherTitles();
        }
    }
}
