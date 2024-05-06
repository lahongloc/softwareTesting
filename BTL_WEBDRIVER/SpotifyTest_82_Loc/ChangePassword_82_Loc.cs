using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections.ObjectModel;

namespace SpotifyTest_82_Loc
{
    [TestClass]
    public class ChangePassword_82_Loc
    {
        public IWebDriver driver_82_Loc;
        public string baseUrl_82_Loc;
        [TestInitialize]
        public void SetUp()
        {
            this.driver_82_Loc = new ChromeDriver();
            this.baseUrl_82_Loc = "https://www.spotify.com/vn-vi/account/change-password/";
        }

        [TestMethod]
        public void ChangePasswordSuccess_82_Loc()
        {
            // E1: //*[@id=\"__next\"]/div[1]/div/div[2]/div[2]/section/div/span/span
            // E2: //*[@id=\"__next\"]/div[1]/div/div[2]/div[2]/article/section/form/div[3]/div[3]/span
            // E3: //*[@id="__next"]/div[1]/div/div[2]/div[2]/article/section/form/div[1]/div[3]/span

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

            this.driver_82_Loc.Navigate().GoToUrl(this.baseUrl_82_Loc);

            IWebElement oldPass_82_Loc = this.driver_82_Loc.FindElement(By.Id("old_password"));
        }
    }
}
