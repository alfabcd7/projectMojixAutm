using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yopEmail.code.control
{
    public class TextBox : Controller
    {
        public TextBox(By locator) : base(locator)
        {
        }

        public void SetText(String value)
        {
            FindControl();
            controller.Clear();
            controller.SendKeys(value);
        }

    }
}
