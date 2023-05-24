using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectasd.src.code.page;
using yopEmail.code.page;
using yopEmail.code.test;

namespace TestProjectasd.src.code.test
{
    [TestClass]
    public class TodoIstTest: TestBase
    {
        TodoIstTest() {
            baseUrl = "https://todoist.com/";
        }
        TodoIstMainPage mainPage = new TodoIstMainPage();
        AddProject addProject = new AddProject();
        LeftProjectMenu leftProjectMenu = new LeftProjectMenu();
        EditProject editProject = new EditProject();


        [TestMethod]
        public void testProject() {
            String nameProject = "aProjectName";

            mainPage.addProject.Click();
            addProject.name.SetText(nameProject);
            addProject.color.Click();
            addProject.berryRed.Click();  
            addProject.addButton.Click();

            Assert.IsTrue(leftProjectMenu.findTextProjectName(nameProject),"Error");

            leftProjectMenu.findOptionMenuByProject(nameProject).Click();

            leftProjectMenu.editProjectButton.Click();
            editProject.name.SetText(nameProject + "algomas");
            editProject.color.Click();
            editProject.yellow.Click();
            editProject.addButton.Click();

            Assert.IsTrue(leftProjectMenu.findTextProjectName(nameProject + "algomas"), "Error");

            leftProjectMenu.findOptionMenuByProject(nameProject + "algomas").Click();
            leftProjectMenu.deleteProject.Click();

        }
    }
}
