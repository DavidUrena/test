namespace Test.POM
{
    class BasePage
    {
        public static void OpenURL()
        {
            Driver.Instance.Navigate().GoToUrl(StaticComponents.URL);
        }

        public static bool PageSourceContains(string pageSourceCode)
        {
           return Driver.Instance.PageSource.Contains(pageSourceCode);

        }
    }
}