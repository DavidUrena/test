using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Test.POM;

namespace Test
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }


        public static void Initialize()
        {
            if (StaticComponents.browser.Equals("Chrome"))
            {
                Instance = new ChromeDriver();
                Instance.Manage().Window.Maximize();
                Instance.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromMinutes(5));
            }
            else if (StaticComponents.browser.Equals("Firefox"))
            {
                {
                    Instance = new FirefoxDriver();
                    Instance.Manage().Window.Maximize();
                    Instance.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromMinutes(5));
                }
            }
        }
        
        public static void Terminate() 
        {
            Instance.Quit();
        }
}
}