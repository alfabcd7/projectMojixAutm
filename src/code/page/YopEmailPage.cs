using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yopEmail.code.control;

namespace yopEmail.code.page
{
    public class YopEmailPage
    {
        public Button newEmail = new Button(By.XPath("//button[@id='newmail']"));
        public Button sendMessage = new Button(By.XPath("//button[@id='msgsend']"));
        public Button refresh = new Button(By.XPath("//button[@id='refresh']"));
        public TextBox to = new TextBox(By.XPath("//input[@id='msgto']"));
        public TextBox subject = new TextBox(By.XPath("//input[@id='msgsubject']"));
        public TextBox bodyMssg = new TextBox(By.XPath("//div[@id='msgbody']"));
    }
}
