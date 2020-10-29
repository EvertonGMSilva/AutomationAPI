using System;
using System.Threading;
using Automation.BasePage;
using Coypu;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation.Base
{
    class OringinPage 
    {        
        public static string LicenseKeyPv;

        public static By btnLogin = By.XPath("//a[contains(text(), 'Login')]");
        public static By inptEmail = By.Id("email");
        public static By inptSenha = By.Id("password");
        public static By btnLoginOK = By.XPath("//button[contains(text(), 'Login')]");
        public static By chaveDeLicenca = By.XPath("(//p[contains(text(), 'Private License Key: ')]//following::strong)[1]");
        public static By inptLicenseKey = By.Id("license");
        public static By inptCity = By.Id("city");
        public static By inptState = By.Id("state");
        public static By btnTry = By.XPath("//button[contains(text(), 'Try')]");
        public static readonly  By txtResultCode = By.XPath("(//button[contains(text(), 'Try')]//following::p)[1]");

        public string ResultCode()
        {
            return driver.FindElement(txtResultCode).Text.Replace("Result Code: ", "").Replace(" ","");
        }

        public string ResultCodeSemReplace()
        {
            return driver.FindElement(txtResultCode).Text.Replace("Result Code: ","");
        }

        public void ClickTry()
        {
            driver.FindElement(btnTry).Click();
        }

        public void SendState(string State)
        {
            driver.FindElement(inptState).SendKeys(State);
        }

        public void SendCity(string City)
        {
            driver.FindElement(inptCity).SendKeys(City);
        }
        public void SendLicenseKey()
        {
            driver.FindElement(inptLicenseKey).SendKeys(LicenseKeyPv);
        }       

        private IWebElement loginOK()
        {
            return driver.FindElement(btnLoginOK);
        }

        public void LoginOK()
        {
            loginOK().Click();
        }

        public void Email()
        {
            driver.FindElement(inptEmail).SendKeys("guilherme20.silva99@gmail.com");
        }        

        public void Senha()
        {
            driver.FindElement(inptSenha).SendKeys("EvertonMETA");
        }        

        public void ClickLogin()
        {
            driver.FindElement(btnLogin).Click();
        }        

        private IWebDriver driver;

        public OringinPage(IWebDriver driver)
        {
            this.driver = driver;           
        }

        public void Site(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        public void Sleep(int milliseconds)
        {
            try
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(milliseconds));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string ChaveSeg()
        {
            Sleep(2000);
            LicenseKeyPv = driver.FindElement(chaveDeLicenca).Text;

            return LicenseKeyPv;
        }

        public string ObtemRespostaAPI()
        {
            string RespAPI = driver.FindElement(txtResultCode).Text;

            return RespAPI;
        }
    }
}