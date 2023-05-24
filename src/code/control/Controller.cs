using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yopEmail.code.session;

namespace yopEmail.code.control
{
    public class Controller
    {
        protected By locator;
        protected IWebElement controller;
        public Controller(By locator)
        {
            this.locator = locator;
        }

        protected void FindControl()
        {
            controller = Session.Instance().GetBrowser().FindElement(locator);
        }

        public void Click()
        {
            FindControl();
            controller.Click();
        }

        public Boolean IsControlDisplayed()
        {
            try
            {
                FindControl();
                return controller.Displayed;
            }
            catch (Exception ex)
            {
             
                return false;
            }
        }

        

    }
}
