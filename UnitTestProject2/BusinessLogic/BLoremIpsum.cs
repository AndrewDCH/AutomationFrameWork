using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    public class BLoremIpsum : BaseClass
    {
        
        IWebDriver driver;
        
        public BLoremIpsum(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string LoremText(int number)
        {
            LoremIpsumPage lorem = new LoremIpsumPage(driver);
            //Здесь изначально были методы. Их стоило оставить?
            
            
            lorem.byteRadioBtn.Click();
            lorem.field.Clear();
            lorem.field.SendKeys(number.ToString());
            lorem.generateBtn.Click();
            
            lorem.loremText = lorem.loremTextBlock.Text;            
            return lorem.loremText;
        }
        
    }
}
