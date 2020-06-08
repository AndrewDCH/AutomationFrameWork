using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject2.Hooks
{
    [Binding]
    public class GeneralHooks
    {
        private IWebDriver _driver;

        [BeforeScenario]
        public void RunBeforeScenario()
        {
            _driver = new ChromeDriver();
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            //_driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);
            _driver.Manage().Window.Maximize();
            ScenarioContext.Current.Add("currentDriver", _driver);
        }

        [AfterScenario]
        public void RunAfterScenario()
        {
            _driver?.Quit();
        }
    }
}

