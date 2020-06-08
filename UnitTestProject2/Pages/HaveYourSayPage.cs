using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace UnitTestProject2
{
    public class 
        
        HaveYourSayPage : BaseClass
    {
        
        IWebDriver driver;
        public HaveYourSayPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(20)));
        }



        [FindsBy(How = How.XPath, Using = "(//a/h3[contains(text(), 'Do you have a question for BBC News?')])[3]")]
        internal IWebElement questionToBBC;

        //[FindsBy(How = How.XPath, Using = GetFormXPath("Name"))] 
        internal IWebElement userName;

        //[FindsBy(How = How.XPath, Using = "//input[@aria-label='Email address']")]
        internal IWebElement userEmail;

        //[FindsBy(How = How.XPath, Using = "//input[@aria-label='Age']")]
        internal IWebElement age;

        //[FindsBy(How = How.XPath, Using = "//input[@aria-label='Postcode']")]
        internal IWebElement postcode;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(), 'Sign me up for BBC News Daily')]")]
        internal IWebElement daily;

        //[FindsBy(How = How.XPath, Using = "//textarea[@aria-label='What questions would you like us to investigate?']")]
        internal IWebElement textarea;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Submit')]")]
        internal IWebElement submitBtn;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),\"Name can't be blank\")]")]
        internal IWebElement inputErrorNameText;

        [FindsBy(How = How.XPath, Using = "//div[@class='input-error-message']")]
        internal IWebElement inputErrorEmailText;

        

       
    }
}
