using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject2
{
    [Binding]
    public class AreEqualTitleAfterSearchSteps
    {
        private IWebDriver _driver;

        public AreEqualTitleAfterSearchSteps()
        {
            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");

        }

        [Given(@"I go to BBC home page and click on News")]
        public void GivenIGoToBBCHomePageAndClickOnNews()
        {
            HomePage home = new HomePage(_driver);
            
            home.GoToBBC();
            home.ClickNews();
        }
        
        [When(@"I fill the search form with category of main article and navigated to search results page")]
        public void WhenIFillTheSearchFormWithCategoryOfMainArticleAndNavigatedToSearchResultsPage()
        {
            NewsPage news = new NewsPage(_driver);
            news.Search();
        }
        
        [Then(@"Check are equal title of first article to hardcoded")]
        public void ThenCheckAreEqualTitleOfFirstArticleToHardcoded()
        {
            SearchResults search = new SearchResults(_driver);
            search.AreEqualFirstArticle("Dangerous heatwave starts hitting US and Canada");
        }
    }
}
