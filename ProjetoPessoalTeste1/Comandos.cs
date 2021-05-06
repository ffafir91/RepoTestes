using System;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ProjetoPessoalTeste1
{
    class Comandos
    {
        public static IWebDriver GetBrowserLocal(IWebDriver driver, String browser)
        {
            switch (browser)
            {
                case "Internet Explorer":
                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    break;
                case "Chrome":
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Cookies.DeleteAllCookies();
                    break;
                default:
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    break;
            }
            return driver;
        }
    }
}
