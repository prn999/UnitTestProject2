using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace UnitTestProject2
{ 
    public class HomePage

    {
        public IWebDriver driver;

        //Constructor enables auto request of driver 
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        //Element id of Search box and button in home page
        IWebElement searchBox => driver.FindElement(By.ClassName("CoveoQueryBox"));
        IWebElement searchBoxEnterTab => driver.FindElement(By.CssSelector("div[class='coveo-text']"));
        
        //Header pages links
        IWebElement productsHeaderLink => driver.FindElement(By.XPath("//a[@class = 'underline' and @title = 'Products']"));
        IWebElement marketsHeaderLink => driver.FindElement(By.XPath("//a[@class = 'underline' and @title = 'Markets']"));
        IWebElement technologiesHeaderLink => driver.FindElement(By.XPath("//a[@class = 'underline' and @title = 'Technologies']"));
        IWebElement supportHeaderLink => driver.FindElement(By.XPath("//a[@class = 'underline' and @title = 'Support']"));

        //Navigate to home page
        public void goToHomePage()
        {
            driver.Navigate().GoToUrl("https://developer.arm.com/");
        }
        
        //Function to search using search bocx on the home page
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
       
        //Navigate to the products page
        public void clickOnProductsPageTitleLink()
        {
            productsHeaderLink.Click();
        }
        
        //Navigate to the markets page
        public void clickOnMarketsPageTitleLink()
        {
            marketsHeaderLink.Click();
        }
        
        //Navigate to the technologies page
        public void clickOnTechnologiesPageTitleLink()
        {
            technologiesHeaderLink.Click();
        }
        
        //Navigate to the support page
        public void clickOnSupportPageTitleLink()
        {
            supportHeaderLink.Click();
        }
        

    }
}