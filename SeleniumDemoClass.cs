
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
    public class SearchGoogle
    {
        public IWebDriver? driver;
        [Test]
        public void SearchForCheese()
        {
            driver = new ChromeDriver();    
            driver!.Navigate().GoToUrl("http://www.google.com/");
            driver?.Quit();
        }
    }
}