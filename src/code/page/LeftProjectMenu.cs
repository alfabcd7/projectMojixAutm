using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yopEmail.code.control;

namespace TestProjectasd.src.code.page
{
    public class LeftProjectMenu
    {


        public Button optionMenuByProject;
        public TextBox projectName;
        public Button editProjectButton = new Button(By.XPath("//div[contains(text(),\"Editar proyecto\")]"));
        public Button deleteProject = new Button(By.XPath("//div[contains(text(), 'Eliminar proyecto')]"));
        


        public Button findOptionMenuByProject(String text) {
            optionMenuByProject = new Button(By.XPath("//a[starts-with(span[contains(text(),'"+ text + "')],'"+ text +"')]/following-sibling::div[1]/button))"));
            return optionMenuByProject;        
        }

        public Boolean findTextProjectName(String text) {
            projectName = new TextBox(By.XPath("//a[starts-with(span[contains(text(),'" + text + "')],'" + text + "')]"));
            return projectName.IsControlDisplayed();        
        }

    }
}
