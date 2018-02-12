using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumTestTool.drivers;
using System.Threading;

namespace SeleniumTestTool.Pages
{
    public class LoginPage : firefox
    {
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void Login()
        {
            string email = "muh.ozkurt27@gmail.com";
            string password = "123456321";

            Thread.Sleep(5000);

            driver.FindElement(By.XPath("/html/body/div[7]/div/div/div/div/div/div/div[1]")).Click();

            Actions action = new Actions(driver);
            IWebElement gy = driver.FindElement(By.XPath("//*[@id='accountNavigationRoot']/div/ul/li[1]"));
            action.MoveToElement(gy).Build().Perform();


            driver.FindElement(By.XPath("//*[@id='accountNavigationRoot']/div/ul/li[1]/div[2]/div/div[1]")).Click();

            driver.FindElement(By.Id("email")).SendKeys(email);
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.XPath("//*[@id='loginSubmit']")).Click();
            
            

        }

        public void VerifyLogin()
        {
            IWebElement err;
            try
            {
                err = driver.FindElement(By.XPath("//*[@id='errorBox']"));
            }
            catch (NoSuchElementException)
            {
                log.Write("email / password doğru.");
                return;
            }

            log.Write("email / passwrod hatalı.");
            
        }
        
        public void VerifyTitle()
        {
            string title = driver.Title;
            if (title.Length > 0)
                log.Write("Login Yapıldı.");
            else
                log.Write("Login Yapılamadı.");
        }
    }
}

