using System;
using DemoTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UITestsDemo
{
    [TestClass]
    public class HomePageTests
    {
        [TestMethod]
        public void Can_Go_To_HomePage()
        {
            Pages.HomePage.GoTo();
            Assert.IsTrue(Pages.HomePage.IsAt());

        }

        [TestMethod]
        public void Can_Go_To_Certifications_Page()
        {
            //TODO: implementar metodos en HomePage
            Pages.HomePage.GoTo();
            Pages.HomePage.ClickCertifications();
            Assert.IsTrue(Pages.HomePage.IsAtCertificationsPage());

        }

        [TestCleanup]

        public void CleanUp()
        {
            Browser.Close();
        }
    }
}
