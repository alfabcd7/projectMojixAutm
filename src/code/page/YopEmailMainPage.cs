using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yopEmail.code.control;

namespace yopEmail.code.page
{
    public class YopEmailMainPage
    {
        public TextBox textBox = new TextBox(By.XPath("//input[@placeholder='Ingrese una dirección aquí']"));
        public Button arrowButton = new Button(By.XPath("//button[@class='md']"));


    }
}
