using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject2
{
    [Binding]
    public class AreEqualMainTitileOfArticleSteps
    {
        private IWebDriver _driver;
        
        public AreEqualMainTitileOfArticleSteps()
        {
            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            
        }

        
        

        [Given(@"I go to BBC HomePage")]
        public void GivenIGoToBBCHomePage()
        {
            HomePage home = new HomePage(_driver);
            home.GoToBBC();
        }
        
        [When(@"I click on button News")]
        public void WhenIClickOnButtonNews()
        {
            HomePage home = new HomePage(_driver);
            home.ClickNews();
        }
        
        [Then(@"Title of main article will be equal to hardcoded")]
        public void ThenTitleOfMainArticleWillBeEqualToHardcoded()
        {
            NewsPage news = new NewsPage(_driver);
            news.AreEqualMainArticleTitle("'No chance of US deal' if Brexit hits Irish accord");
        }
    }
}
