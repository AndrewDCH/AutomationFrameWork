using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driver = new ChromeDriver();

        
        NewsPage news = new NewsPage(driver);
        LoremIpsumPage lorem = new LoremIpsumPage(driver);
        BLoremIpsum Blorem = new BLoremIpsum(driver);
        HaveYourSayPage yoursay = new HaveYourSayPage(driver);
        BHaveYourSay Byoursay = new BHaveYourSay(driver);
        SearchResults afterSearch = new SearchResults(driver);


        
        [TestMethod]
        public void TestMethod1()
        {
            
        }

        [TestMethod]
        public void TestMethod2()
        {
            
        }

        [TestMethod]
        public void TestMethod3()
        {
            
        }

        
        [TestMethod]
        public void TestMethod4()
        {
            

        }

        [TestMethod]
        public void TestMethod5()
        {
            string text = Blorem.LoremText(141);

            Dictionary<string, string> values = new Dictionary<string, string>(5);
            values.Add("Name", "dimasik");
            values.Add("Email address", "dmtreaqq@gmail.com");
            values.Add("Age", "20");
            values.Add("Postcode", "02183");
            values.Add("What", text);

            Byoursay.FillTheForm(values, true);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string text = Blorem.LoremText(140);

            Dictionary<string, string> values = new Dictionary<string, string>(5);
            values.Add("Name", "");
            values.Add("Email address", "dmtreaqq@gmail.com");
            values.Add("Age", "20");
            values.Add("Postcode", "02183");
            values.Add("What", text);

            Byoursay.FillTheForm(values, false);
        }

        [TestMethod]
        public void TestMethod7()
        {
            string text = Blorem.LoremText(140);

            Dictionary<string, string> values = new Dictionary<string, string>(5);
            values.Add("Name", "dimasik");
            values.Add("Email address", "");
            values.Add("Age", "20");
            values.Add("Postcode", "02183");
            values.Add("What", text);

            Byoursay.FillTheForm(values, false);
        }
        
        [TestMethod]
        public void Z_Quit()
        {
            Thread.Sleep(5000);
            driver.Quit();
        }
        
        

        /* открытие вкладки, вернуться на предыдущую
        [TestMethod]
        public void Test()
        {
            driver.Navigate().GoToUrl("http://bbc.com");
            IJavaScriptExecutor jse = driver as IJavaScriptExecutor;
            jse.ExecuteScript("window.open('http://google.com')");

            string handle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(handle);
        }
        */
    }
}