using Automation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Automation.Steps
{
    class TesteMETAStep
    {      
        string url = "https://interzoid.com/";
        IWebDriver driver;
        OringinPage basePage;

        [Given(@"que acesso a o link para acesso")]
        public void DadoQueAcessoAOLinkParaAcesso()
        {
            driver = new ChromeDriver();
            basePage.Site(url);
        }
    }
}
