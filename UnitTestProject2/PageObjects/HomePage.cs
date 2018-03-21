using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace UnitTestProject2
{ 
    public class HomePage

    {
        public IWebDriver driver;

        //Constructor with auto request driver when called 
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement searchBox => driver.FindElement(By.ClassName("CoveoQueryBox"));
        IWebElement searchBoxEnterTab => driver.FindElement(By.CssSelector("div[class='coveo-text']"));

        IWebElement productsHeaderLink => driver.FindElement(By.XPath("//a[@class = 'underline' and @title = 'Products']"));
        IWebElement marketsHeaderLink => driver.FindElement(By.XPath("//a[@class = 'underline' and @title = 'Markets']"));
        IWebElement technologiesHeaderLink => driver.FindElement(By.XPath("//a[@class = 'underline' and @title = 'Technologies']"));
        IWebElement supportHeaderLink => driver.FindElement(By.XPath("//a[@class = 'underline' and @title = 'Support']"));


        public void goToHomePage()
        {
            driver.Navigate().GoToUrl("https://developer.arm.com/");
        }
        public void searchText(string text)
        {
            searchBox.SendKeys(text);
            Thread.Sleep(1000);
            //WebDriverWait wait = new WebDriverWait(driver, new System.TimeSpan (1000));
            //Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver Web) ->
            //    {
            //    if (searchBoxEnterTab.Displayed)
            //    { return true;
            //    }
            //    });
            //wait.Until(waitForElement);
            searchBoxEnterTab.Click();

        }
        public void clickOnProductsPageTitleLink()
        {
            productsHeaderLink.Click();
        }
        public void clickOnMarketsPageTitleLink()
        {
            marketsHeaderLink.Click();
        }
        public void clickOnTechnologiesPageTitleLink()
        {
            technologiesHeaderLink.Click();
        }
        public void clickOnSupportPageTitleLink()
        {
            supportHeaderLink.Click();
        }
        

    }
}