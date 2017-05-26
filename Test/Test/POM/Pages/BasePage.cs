

namespace Test.POM
{
    class BasePage
    {
        public void OpenURL()
        {
            Driver.Instance.Navigate().GoToUrl(StaticComponents.URL);
        }
    }
}
