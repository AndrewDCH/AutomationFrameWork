using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace UnitTestProject2
{
    class SearchResults : BaseClass
    {
        IWebDriver driver;
        public SearchResults(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(20)));
        }

        [FindsBy(How = How.XPath, Using = "//ol[@class='search-results results']/li[@data-result-number='1']//h1//a")]
        private IWebElement firstArticleAfterSearch;

        public void AreEqualFirstArticle(string hardCoded)
        {
            Assert.AreEqual(hardCoded, firstArticleAfterSearch.Text);

        }
    }
}
