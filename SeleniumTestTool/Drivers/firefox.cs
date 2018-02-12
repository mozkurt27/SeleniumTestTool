using OpenQA.Selenium;
using SeleniumTestTool.Log;

namespace SeleniumTestTool.drivers
{
    public class firefox
    {
        protected IWebDriver driver;
        protected string link;
        protected TestLog log;
        public firefox()
        {
            log = new TestLog();
            
        }
        protected void openUrl()
        {

            driver.Navigate().GoToUrl(link);
        }
    }
}
