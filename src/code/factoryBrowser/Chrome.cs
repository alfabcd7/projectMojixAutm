using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yopEmail.code.factoryBrowser
{
    public class Chrome : IBrowser
    {
        //Resolucion, cookies, configuraciones, certificados, etc. Se hacen en esta clase.
        public IWebDriver Create()
        {
            string path = new DirectoryInfo(Directory.GetCurrentDirectory())
                            .Parent.Parent.Parent.FullName + "\\resources\\driver\\chromedriver.exe";
            Console.WriteLine(path);    
            IWebDriver driver = new ChromeDriver(path);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
