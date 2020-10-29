using Automation.Base;
using Automation.BasePage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Automation.Steps
{
    [Binding]
    public class _1TestesMETASteps
    {

        string url1 = "https://interzoid.com/";
        string url2 = "https://www.interzoid.com/services/getweathercity";
        IWebDriver driver;
        OringinPage oringinPage;        

        [Given(@"que acesso a o link para Login")]
        public void QueAcessoAOLinkParaLogin()
        {
            driver = new ChromeDriver();
            oringinPage = new OringinPage(driver);
            oringinPage.Site(url1);            
        }

        [Given(@"realizo o login")]
        public void RealizoOLogin()
        {
            oringinPage.ClickLogin();
            oringinPage.Email();
            oringinPage.Senha();
            oringinPage.LoginOK();
            oringinPage.Sleep(2000);
            oringinPage.ChaveSeg();
            driver.Quit();
        }

        [Given(@"entro acesso o link para consulta de dados")]
        public void EntroAcessoOLinkParaConsultaDeDados()
        {
            driver = new ChromeDriver();
            oringinPage = new OringinPage(driver);
            oringinPage.Site(url2);
            oringinPage.Sleep(2000);
            oringinPage.SendLicenseKey();
        }

        [When(@"digito a (.*) e o (.*)")]
        public void QuandoDigitoAEO(string City, string State)
        {         
            oringinPage.SendCity(City);
            oringinPage.SendState(State);
            oringinPage.ClickTry();
        }

        [Then(@"Valido o (.*) da API")]
        public void EntaoValidoODaAPI(string Retorno)
        {
            oringinPage.Sleep(1000);
            var retornoReplace = oringinPage.ResultCode();            
            oringinPage.Sleep(500);
            Assert.AreEqual(Retorno, retornoReplace);            
            driver.Quit();
        }

        [Then(@"Valido o (.*) da api")]
        public void EntaoValidoODaApi(string retorno)
        {            
            oringinPage.Sleep(1000);            
            var _retorno = oringinPage.ResultCodeSemReplace();
            oringinPage.Sleep(500);            
            Assert.AreEqual(retorno, _retorno);
            driver.Quit();
        }
    }
}
