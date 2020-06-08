using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace UnitTestProject2
{
    public class NewsPage : BaseClass
    {
        IWebDriver driver;
        public NewsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(20)));
        }

        [FindsBy(How = How.XPath, Using = "(//*[@data-entityid='container-top-stories#1']//h3)[1]")]
        private IWebElement mainArticle;

        [FindsBy(How = How.XPath, Using = "//a[@class='gs-c-section-link gs-c-section-link--truncate nw-c-section-link nw-o-link nw-o-link--no-visited-state']/span")]
        private IWebElement category;

        [FindsBy(How = How.XPath, Using = "//*[@id='orb-search-q']")]
        private IWebElement searchField;

        [FindsBy(How = How.XPath, Using = "//*[@id='orb-search-button']")]
        private IWebElement searchButton;

        [FindsBy(How = How.XPath, Using = "//nav[@role='navigation']/ul/li[last()]")]
        private IWebElement moreDropdown;

        [FindsBy(How = How.XPath, Using = "//a[@class='nw-o-link']/span[contains(text(),'Have Your Say')]")]
        private IWebElement haveYourSay;

        public void AreEqualMainArticleTitle(string hardCoded)
        {
            Assert.AreEqual(hardCoded, mainArticle.Text);
        }

        public void AreEqualOtherTitles()
        {
            List<string> titles = new List<string>();
            titles.Add("Are the markets signalling a recession is due?");
            titles.Add("Is the bystander effect a myth?");
            titles.Add("British-Iranian academic 'arrested in Iran'");
            titles.Add("Wildfires leave blackened forests in their wake");
            titles.Add("ASAP Rocky found guilty of assault");

            string xpath;
            foreach (string i in titles)
            {
                xpath = "//h3[contains(text()," + '\"' + i + '\"' + ")]";
                driver.FindElement(By.XPath(xpath));
            }
        }

        public void Search()
        {
            searchField.SendKeys(category.Text);
            searchButton.Click();
        }

        public void MoreDropdownClick()
        {
            moreDropdown.Click();
        }

        public void HaveYourSayClick()
        {
            haveYourSay.Click();
        }
    }
}
