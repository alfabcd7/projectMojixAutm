using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yopEmail.code.page;
using yopEmail.code.session;

namespace yopEmail.code.test
{
    [TestClass]
    public class LoginTestYopEmail : TestBase{
        public LoginTestYopEmail()
        {
            baseUrl = "https://yopmail.com/"; // Establece la URL deseada aquí
        }

        YopEmailMainPage mainPage= new YopEmailMainPage();
        YopEmailPage emailPage= new YopEmailPage();

        [TestMethod]
        public void VerifyEmail()
        {
            string emailAdrress = "carlitos2@gmail.com";
            string subject = "testingProject";
            string body = "This is a message to pass a project automation";
            mainPage.textBox.SetText(emailAdrress);
            mainPage.arrowButton.Click();
            emailPage.newEmail.Click();
            
            Console.WriteLine("esperando");
           // Session.Instance().GetBrowser().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           // ...
            Session.Instance().GetBrowser().SwitchTo().Frame("//iframe[@name='ifmail']");
            Console.WriteLine("sigo");
            emailPage.to.SetText(emailAdrress);
            emailPage.subject.SetText(emailAdrress);
            emailPage.bodyMssg.SetText(body);
            emailPage.sendMessage.Click();
            emailPage.refresh.Click();

        }
    }

}
