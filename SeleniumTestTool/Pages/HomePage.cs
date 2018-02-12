using OpenQA.Selenium;
using SeleniumTestTool.drivers;


namespace SeleniumTestTool.Pages
{
    public class HomePage : firefox
    {
        
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            this.link = @"http://www.trendyol.com";
        }

        public void Open()
        {
            this.openUrl();
        }

        
        public void VerifyTitle()
        {
            string title = driver.Title;
            if (title.Length > 0)
                log.Write("Anasayfa Açıldı.");
            else
                log.Write("Anasayfa Açılamadı.");
        }
    }
}
