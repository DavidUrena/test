
using System.Configuration;

namespace Test.POM
{
    class StaticComponents
    {
        public static readonly string browser = ConfigurationManager.AppSettings["Browser"];
        public static readonly string URL = ConfigurationManager.AppSettings["Url"];
    }
}
