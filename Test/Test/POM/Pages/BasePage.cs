using System;
using OpenQA.Selenium;

namespace Test.POM
{
    class BasePage
    {
        #region Elements

        private static IWebElement DateofDate
        {
            get { return Driver.GetElement(By.Id("datepicker")); }
        }

        private static IWebElement PacientDocument
        {
            get { return Driver.GetElement(By.CssSelector("#page-wrapper > div > div:nth-child(3) > div > div:nth-child(2) > input")); }
        }
        private static IWebElement DoctorDocument
        {
            get { return Driver.GetElement(By.CssSelector("#page-wrapper > div > div:nth-child(3) > div > div:nth-child(3) > input")); }
        }
        private static IWebElement Observation
        {
            get { return Driver.GetElement(By.CssSelector("#page-wrapper > div > div:nth-child(3) > div > div:nth-child(4) > textarea")); }
        }
        private static IWebElement SaveButton
        {
            get { return Driver.GetElement(By.CssSelector("#page-wrapper > div > div:nth-child(3) > div > a")); }
        }


        #endregion
        #region Methods

        public static void OpenUrl()
        {
            Driver.Instance.Navigate().GoToUrl(StaticComponents.Url);
        }

        public static void SaveButtonClick()
        {
            SaveButton.Click();
        }

        public static void TypeDate(string date)
        {
            DateofDate.Click();
            DateofDate.SendKeys(date);
        }

        public static void TypePatientDocument(string pacientDocument)
        {
            PacientDocument.Click();
            PacientDocument.SendKeys(pacientDocument);
        }

        public static void TypeDoctorDocument(string doctorDocument)
        {
            DoctorDocument.Click();
            DoctorDocument.SendKeys(doctorDocument);
        }

        public static void TypeObervation(string observation)
        {
            Observation.SendKeys(observation);
        }

        public static bool PageSourceContains(string pageSourceCode)
        {
           return Driver.Instance.PageSource.Contains(pageSourceCode);
        }
        #endregion
    }
}