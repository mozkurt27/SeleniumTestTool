using OpenQA.Selenium;
using SeleniumTestTool.drivers;

namespace SeleniumTestTool.Pages
{
    public class Product : firefox
    {
        public Product(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void selectProduct()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div/div[2]/div/div/div[3]/div[1]/div[1]")).Click();
        }

        public void addToCart()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[2]/div/div[2]/div/form/div[1]/div[3]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[2]/div/div[2]/div/form/div[1]/div[3]/div/ul/div/div[1]/li[2]")).Click();
 
            driver.FindElement(By.Id("addToBasketButton")).Click();
        }
    }
}
