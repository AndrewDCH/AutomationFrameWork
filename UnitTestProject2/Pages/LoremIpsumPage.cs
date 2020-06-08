using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace UnitTestProject2
{

    public class LoremIpsumPage : BaseClass
    {
        IWebDriver driver;

        public LoremIpsumPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(20)));
        }

        [FindsBy(How = How.XPath, Using = "//label[@for='bytes']")]
        internal IWebElement byteRadioBtn;

        [FindsBy(How = How.XPath, Using = "//*[@id='amount']")]
        internal IWebElement field;

        [FindsBy(How = How.XPath, Using = "//*[@id='generate']")]
        internal IWebElement generateBtn;

        [FindsBy(How = How.XPath, Using = "//div[@id='lipsum']/p")]
        internal IWebElement loremTextBlock;

        public string loremText;

    }
}
