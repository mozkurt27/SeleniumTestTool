using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumTestTool.Pages;

namespace SeleniumTestTool.tests
{
    public class Test
    {
        public void successTest()
        {
            IWebDriver driver = new FirefoxDriver();

            HomePage homePage = new HomePage(driver);
            homePage.Open();
            homePage.VerifyTitle();

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login();
            loginPage.VerifyLogin();
            loginPage.VerifyTitle();

            Boutique boutique = new Boutique(driver);
            boutique.clickAllBoutiques();

            Product product = new Product(driver);
            product.selectProduct();
            product.addToCart();
        }
    }
}
