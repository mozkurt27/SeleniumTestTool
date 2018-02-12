using OpenQA.Selenium;
using SeleniumTestTool.drivers;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SeleniumTestTool.Pages
{
    public class Boutique :firefox
    {
        public Boutique(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void clickAllBoutiques()
        {
            Thread.Sleep(2000);
            int tabCount = 0;
            tabCount = driver.FindElement(By.ClassName("main-nav")).
                              FindElements(By.ClassName("tabLink")).Count();
            

            for(int i=0;i < tabCount; i++)
            {
                IReadOnlyCollection<IWebElement> list_of_element = 
                                                    driver.FindElement(By.ClassName("main-nav")).
                                                           FindElements(By.ClassName("tabLink"));
                list_of_element.ElementAt(i).Click();
                VerifyTitle();
                isUploadedAllImage();
                Thread.Sleep(1000);
                
            }

            driver.FindElement(By.ClassName("main-nav")).
                   FindElements(By.ClassName("tabLink")).First().Click();


            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div/div")).
                   FindElements(By.ClassName("butik-large-image")).First().Click();


        }

        private void isUploadedAllImage()
        {
            int count = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div/div")).
                               FindElements(By.ClassName("butik-large-image")).Count();
            if (count != 20)
                log.Write("yüklenmeyen imaj görseli.");
        }

        private void VerifyTitle()
        {
            string title = driver.Title;
            if (title.Length > 0)
                log.Write("İmaj yüklendi.");
            else
                log.Write("İmaj yüklenemedi.");
        }
    }
}
