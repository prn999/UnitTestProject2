using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace UnitTestProject2
{
    [Binding]
    public class UserAbleToViewProductsOnSiteSteps
    {
        static IWebDriver driver = new ChromeDriver();
        HomePage homepage = new HomePage(driver);

        [Given(@"user is on developer home page")]
        public void GivenUserIsOnDeveloperHomePage()
        {
            driver.Manage().Window.Maximize();
            homepage.goToHomePage();
            Assert.AreEqual("Home – Arm Developer", driver.Title);
        }


        [When(@"user clicks products page link")]
        public void WhenUserClicksProductsPageLink()
        {
            homepage.clickOnProductsPageTitleLink();
        }

        [Then(@"products page is displayed")]
        public void ThenProductsPageIsDisplayed()
        {
            Assert.True(driver.Title == "Products – Arm Developer");
        }
    }
}
