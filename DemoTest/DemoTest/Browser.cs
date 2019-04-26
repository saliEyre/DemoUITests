using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace DemoTest
{
    public static class Browser
    {
        static IWebDriver webDriver = new FirefoxDriver(@"C:\Users\Linnet Acosta\Desktop\curso Linnet\Demos\DemoTest\packages");

        public static object Title
        {
            get
            {
                return webDriver.Title;
            }
        }

        public static void Close()
        {
            webDriver.Close();
        }

        public static void GoTo(string url)
        {
            webDriver.Url = url;
        }
    }
}
