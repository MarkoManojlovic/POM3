
using OpenQA.Selenium;
using PomTesting.Driver;
using PomTesting.Page;
using WebDriver = PomTesting.Driver.WebDriver;

namespace PomTesting
{
    public class Tests
    {
        private LoginPage _loginPage;
        private HomePage _homePage;

        [SetUp]
        public void BeforeScenario()
        {
            WebDriver.Initialize();
            _loginPage = new LoginPage();
            _homePage = new HomePage();

        }
        [TearDown]
        public void AfterScenario()
        {
            WebDriver.CleanUp();
        }

        [Test]
        public void TC01_PURCASHEOFPRODUCT()
        {
            Login("standard_user", "secret_sauce");
            _homePage.BackPack.Click();
            _homePage.AddButton.Click();
            _homePage.BackButton.Click();
            
        }
        public void Login(string name, string pass)
        {
            _loginPage.LoginOnPage(name, pass);
        }
    }
}