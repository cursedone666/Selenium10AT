using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    public class BaseTest
    {
        
            private IWebDriver chrome;

            public void Dispose()
            {
                chrome.Quit();
            }

            public IWebDriver StartDriverWithUrl(string url)
            {
                chrome = new ChromeDriver();
                chrome.Navigate().GoToUrl(url);
                chrome.Manage().Window.Maximize();
                chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                return chrome;
            }
        
    }
}

