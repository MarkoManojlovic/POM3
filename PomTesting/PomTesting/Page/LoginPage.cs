
using OpenQA.Selenium;
using PomTesting.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver = PomTesting.Driver.WebDriver;

namespace PomTesting.Page
{
    public class LoginPage
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement UserName => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login-button"));

        public void LoginOnPage(string name, string pass)
        {
            UserName.SendKeys(name);
            Password.SendKeys(pass);
            LoginButton.Submit();
        }
            
            }
}
