
using OpenQA.Selenium;

namespace UnitTestProject2
{
    public class BaseClass
    {
        
        public string GetTextXPath(string elementLabel, int elementNumber)
        {
            return "(//*[contains(text()," + "'" + elementLabel + "')])" + "[" + elementNumber + "]";
        }

        public string GetFormXPath(string fieldName)
        {
            return "//*[@placeholder ='" + fieldName + "']";
        }
    }
}
