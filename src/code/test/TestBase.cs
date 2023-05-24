using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yopEmail.code.test
{
    [TestClass]
    public class TestBase{
        protected string baseUrl = "https://yopmail.com/";
        [TestInitialize]
        public void OpenBrowser()
        {
            session.Session.Instance().GetBrowser().Navigate().GoToUrl(baseUrl);

        }

        [TestCleanup]
        public void CloseBrowser()
        {
            session.Session.Instance().CloseBrowser();

            // session.Session.Instance().GetBrowser().SwitchTo().Alert().Accept();
        }



    }
}
