using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yopEmail.code.factoryBrowser;

namespace yopEmail.code.session
{
    public class Session
    {
        //Para lograr el singleton se necesitan tres cosas basicas
        // 1.- Un atributo del mismo tipo
        private static Session instance = null;
        private IWebDriver browser;
        // 2.- el constructor debe ser privado
        private Session()
        {
            browser = FactoryBrowser.Make("chrome").Create();
        }
        // 3.- metodo estatico publico para su acceso global
        public static Session Instance()
        {
            if (instance == null)
            {
                instance = new Session();
            }
            return instance;
        }

        public void CloseBrowser()
        {
            instance = null;
            browser.Quit();
        }

        public IWebDriver GetBrowser()
        {
            return browser;
        }

        public void Frame(String frame)
        {
            IWebDriver driver = Session.Instance().GetBrowser();
            driver.SwitchTo().Frame(frame);
        }

    }
}
