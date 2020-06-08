using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace UnitTestProject2
{
    [Binding]
    public class GetLoremTextAndFillFormSteps
    {
        private IWebDriver _driver;

        public GetLoremTextAndFillFormSteps()
        {
            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");

        }

        string text;

        

        [Given(@"I go to lipsum\.com")]
        public void GivenIGoToLipsum_Com()
        {
            _driver.Navigate().GoToUrl("https://www.lipsum.com/");
        }
        
        [When(@"I generate the lorem ipsum text")]
        public void WhenIGenerateTheLoremIpsumText()
        {
            BLoremIpsum blorem = new BLoremIpsum(_driver);
            text = blorem.LoremText(140);
        }
        
        [Then(@"i navigated to page with BBC form and fill it")]
        public void ThenINavigatedToPageWithBBCFormAndFillIt()
        {
            BHaveYourSay have = new BHaveYourSay(_driver);

            Dictionary<string, string> values = new Dictionary<string, string>(5);
            values.Add("Name", "Andrii");
            values.Add("Email address", "andry13net@gmail.com");
            values.Add("Age", "20");
            values.Add("Postcode", "06666");
            values.Add("What", text);

            have.FillTheForm(values, true);
        }
    }
}
