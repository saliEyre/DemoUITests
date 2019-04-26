using System;

namespace DemoTest
{
    public static class Pages
    {
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                return homePage;
            }

        }
    }


    public class HomePage
    {
        static string Url = "https://www.aibes.org/";
        private static string PageTitle = "AIBES — Asociación Iberoamericana de Scrum";
        public void GoTo()
        {
            Browser.GoTo(Url);
        }

        public bool IsAt()
        {
            return Browser.Title.Equals(PageTitle);
        }

        public void ClickCertifications()
        {
            throw new NotImplementedException();
        }

        public bool IsAtCertificationsPage()
        {
            throw new NotImplementedException();
        }
    }
}
