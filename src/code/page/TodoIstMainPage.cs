using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yopEmail.code.control;

namespace TestProjectasd.src.code.page
{
    public  class TodoIstMainPage
    {
        
        public Button addProject = new Button(By.XPath("//button[@aria-label='Añadir proyecto']"));
    }
}
