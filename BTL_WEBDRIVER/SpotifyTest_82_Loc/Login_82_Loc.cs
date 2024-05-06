using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections.ObjectModel;

namespace SpotifyTest_82_Loc
{
    [TestClass]
    public class Login_82_Loc
    {
        public IWebDriver driver_82_Loc;
        public string baseUrl_82_Loc;
        public TestContext TestContext { get; set; }
        [TestInitialize]
        public void SetUp()
        {
            this.driver_82_Loc = new ChromeDriver();
            this.baseUrl_82_Loc = "https://open.spotify.com/";
        }

        //[TestMethod]
        public void TestLoginSuccess_82_Loc()
        {
            string loginUrl_82_Loc = "https://accounts.spotify.com/vi/login";
            this.driver_82_Loc.Navigate().GoToUrl(loginUrl_82_Loc);

            IWebElement usernameInput_82_Loc = this.driver_82_Loc.FindElement(By.Id("login-username"));
            IWebElement passwordInput_82_Loc = this.driver_82_Loc.FindElement(By.Id("login-password"));

            usernameInput_82_Loc.SendKeys("hongloc111990@gmail.com");
            passwordInput_82_Loc.SendKeys("Abcd6789@#");

            IWebElement buttonLogin_82_Loc = this.driver_82_Loc.FindElement(By.Id("login-button"));
            buttonLogin_82_Loc.Click();
            Thread.Sleep(4000);


            IWebElement buttonGoToHome_82_Loc = this.driver_82_Loc.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div/button[2]"));
            buttonGoToHome_82_Loc.Click();

            Thread.Sleep(2000);

            string currentUrl_82_Loc = this.driver_82_Loc.Url;
            Assert.AreEqual(this.baseUrl_82_Loc, currentUrl_82_Loc);
            driver_82_Loc.Close();
        }

        //[TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\LoginFailTestcases_82_Loc.csv", "LoginFailTestcases_82_Loc#csv", DataAccessMethod.Sequential)]
        public void TestLoginFail_82_Loc()
        {
            string loginUrl_82_Loc = "https://accounts.spotify.com/vi/login";
            this.driver_82_Loc.Navigate().GoToUrl(loginUrl_82_Loc);

            IWebElement usernameInput_82_Loc = this.driver_82_Loc.FindElement(By.Id("login-username"));
            IWebElement passwordInput_82_Loc = this.driver_82_Loc.FindElement(By.Id("login-password"));

            string username_82_Loc = TestContext.DataRow[0].ToString();
            string password_82_Loc = TestContext.DataRow[1].ToString();

            usernameInput_82_Loc.SendKeys(username_82_Loc);
            passwordInput_82_Loc.SendKeys(password_82_Loc);

            IWebElement buttonLogin_82_Loc = this.driver_82_Loc.FindElement(By.Id("login-button"));
            buttonLogin_82_Loc.Click();
            Thread.Sleep(2000);

            IWebElement errorMessage_82_Loc = this.driver_82_Loc.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div/div[1]/div/span"));
            Assert.AreEqual("Tên người dùng hoặc mật khẩu không chính xác.", errorMessage_82_Loc.Text.Trim(), "Unexpected error message.");
            Thread.Sleep(3000);
            this.driver_82_Loc.Close();
        }
    }
}
