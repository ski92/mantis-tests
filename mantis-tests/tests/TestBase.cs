using System;
using System.Text;
using NUnit.Framework;


namespace mantis_tests
{
    public class TestBase
    {
        protected ApplicationManager app;

        [TestFixtureSetUp]
        public void SetupApplicationManager()
        {
            app = ApplicationManager.GetInstance();
        }
    }
}