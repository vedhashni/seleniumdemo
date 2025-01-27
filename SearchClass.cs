using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumDemo
{
[TestFixture]
    public class Search
    {
        public IWebDriver? driver;
        [Test]
        public void SearchForCakes()
        {
            driver = new ChromeDriver();    
            driver!.Navigate().GoToUrl("http://www.google.com/");
            driver.FindElement(By.XPath("//textarea[@name='q']")).SendKeys("Cakes");
            driver.FindElement(By.CssSelector("div[class='FPdoLc lJ9FBc'] input[name='btnK']")).Click();
            Thread.Sleep(3000);
            driver?.Quit();
        }
    }
}