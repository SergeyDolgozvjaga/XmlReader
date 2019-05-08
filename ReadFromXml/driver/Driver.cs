using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ReadFromXml
{
    public class Driver
    {
        public IWebDriver driver;

        public void SetUpFireFoxDriver()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
        }

        public void SetUpChromeDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public IWebElement FindElementById(string id)
        {
            IWebElement element = driver.FindElement(By.Id(id));
            return element;
        }

        public SelectElement FindElementByIdAndSelectIt(string id)
        {
            SelectElement element = new SelectElement(driver.FindElement(By.Id(id)));
            return element;
        }

        public IWebElement FindElementByName(string name)
        {
            IWebElement element = driver.FindElement(By.Id(name));
            return element;
        }

        public IWebElement FindElementByXPath(string xpath)
        {
            IWebElement element = driver.FindElement(By.XPath(xpath));
            return element;
        }

        public IWebElement FindElementByIdAndInputData(string text)
        {
            IWebElement element = driver.FindElement(By.Id(text));
            element.SendKeys(text);
            return element;
        }

        public void NavigatePage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public string GetURL()
        {
            return driver.Url;
        }

        public void Close()
        {            
            driver.Quit();
        }
    }
}
