using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yopEmail.code.control;

namespace TestProjectasd.src.code.page
{
    public class EditProject
    {
        public TextBox name = new TextBox(By.XPath("//input[@name='name']"));
        public Button color = new Button(By.XPath("//button[@class='color_dropdown_toggle form_field_control']"));
        public Button yellow = new Button(By.XPath("//li[@data-value='yellow']"));
        public Button addButton = new Button(By.XPath("//button[@type='submit' and @class='_8313bd46 _7a4dbd5f _5e45d59f _2a3b75a1 _56a651f6']"));
    
    }
}
