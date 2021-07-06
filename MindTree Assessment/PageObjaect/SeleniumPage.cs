using MindTree_Assessment.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MindTree_Assessment.PageObjaect
{
    class SeleniumPage
    {
        public SeleniumPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement download => driver.FindElement(By.XPath("//a[text()='Downloads']"));


        IWebElement confirmServerGridIsPresent => driver.FindElement(By.XPath("//h2[text()='Selenium Server (Grid)']"));


        IWebElement about => driver.FindElement(By.XPath("//span[text()='About']"));


        IWebElement governance => driver.FindElement(By.XPath("(//a[text()='Governance'])[1]"));


        IWebElement confirmProjectStructureAndGovernanceIsPresent => driver.FindElement(By.XPath("//h1[text()='Project Structure and Governance']"));


        IWebElement learnMore => driver.FindElement(By.XPath("//B[text()='LEARN MORE']"));


        IWebElement seleniumSponsor => driver.FindElement(By.XPath("//h1[text()='Selenium Sponsors']"));


        IWebElement documentation => driver.FindElement(By.XPath("(//a[text()='Documentation'])[1]"));


        IWebElement search => driver.FindElement(By.XPath("//input[@type='search']"));


        IWebElement searchResult => driver.FindElement(By.XPath("//li[@title='Grid 3']"));







        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }


        public void ClickOnDownload()
        {
            //Thread.Sleep(5000);
            download.Click();
        }


        public bool IsServerGridDisplayed()
        {
            return confirmServerGridIsPresent.Displayed;
        }


        public void ClickAbout()
        {
            about.Click();
        }


        public void ClickGovernance()
           {
            governance.Click();
           }


        public bool IsProjectStructureAndGovernanceDisplayed()
        {
            return confirmProjectStructureAndGovernanceIsPresent.Displayed;
        }


        public void ClickLearnMore()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            learnMore.Click();
        }


        public bool IsSeleniumSponsorDisplayed()
        {
            return seleniumSponsor.Displayed;
        }



        public void ClickDocumentation()
        {
            documentation.Click();
        }


        public void EnterSearchWord(string word)
        {
            Thread.Sleep(5000);
            search.SendKeys(word);
            
        }


        public void SelectResult()
        {
            Thread.Sleep(3000);
            searchResult.Click();
        }
    }
}


