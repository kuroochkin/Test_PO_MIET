using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Assert = NUnit.Framework.Assert;

namespace Selenium
{
    [TestClass]
    public class UnitTest1
    {
        private const string baseUrl = "https://account.miet.ru/login";
        private const string searchUrl = "https://www.miet.ru/search";

        [TestMethod]
        public void SuccessLoginTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(baseUrl);

            driver.FindElement(By.Id("inputLogin")).SendKeys("8211840");
            driver.FindElement(By.Id("inputPassword")).SendKeys("Ваш_Пароль");

            driver.FindElement(By.CssSelector("button.button.blue.big-padding")).Click();

            var homePath = "https://account.miet.ru/applications";

            Thread.Sleep(5000);

            Assert.AreEqual(homePath, driver.Url);
        }

        [TestMethod]
        public void UnSuccessLoginTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(baseUrl);

            driver.FindElement(By.Id("inputLogin")).SendKeys("8211840");
            driver.FindElement(By.Id("inputPassword")).SendKeys("hdfjgh");

            driver.FindElement(By.CssSelector("button.button.blue.big-padding")).Click();

            var homePath = "https://account.miet.ru/login";

            Thread.Sleep(5000);

            Assert.AreEqual(homePath, driver.Url);
        }

        [TestMethod]
        public void SuccessSearch()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(searchUrl);

            var searchInput = driver.FindElement(By.ClassName("search-bar__input"));

            searchInput.SendKeys("Кожухов");

            searchInput.SendKeys(Keys.Enter);

            Thread.Sleep(2000);

            var peoples = driver.FindElement(By.XPath("//a[contains(@class,'search-bar__list-item') and contains(text(),'Люди')]"));

            // Нажимаем на элемент
            peoples.Click();

            Thread.Sleep(2000);

            Assert.IsTrue(driver.FindElement(By.XPath("//a[@class='people-list__item-name' and text()='Кожухов Игорь Борисович']")).Displayed);
        }

        [TestMethod]
        public void UnSuccessSearch()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(searchUrl);

            var searchInput = driver.FindElement(By.ClassName("search-bar__input"));

            searchInput.SendKeys("вапва");

            searchInput.SendKeys(Keys.Enter);

            Thread.Sleep(2000);

            var peoples = driver.FindElement(By.XPath("//a[contains(@class,'search-bar__list-item') and contains(text(),'Люди')]"));

            peoples.Click();

            Thread.Sleep(2000);

            Assert.Throws<NoSuchElementException>(() =>
            {
                var IsFindPerson = driver.FindElement(By.XPath("//a[@class='people-list__item-name' and text()='Кожухов Игорь Борисович']")).Displayed;
            });
        }
    }
}
