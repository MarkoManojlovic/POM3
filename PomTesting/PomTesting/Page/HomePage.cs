
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
    public class HomePage
    {
        private IWebDriver driver = WebDriver.Instance;
        public IWebElement BackPack => driver.FindElement(By.CssSelector("#item_4_img_link"));
        public IWebElement AddButton => driver.FindElement(By.CssSelector("#add-to-cart-sauce-labs-backpack"));
        public IWebElement BackButton => driver.FindElement(By.CssSelector("#back-to-products"));
        
    }
}
