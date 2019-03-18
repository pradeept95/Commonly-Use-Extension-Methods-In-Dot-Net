using Application.Helpers.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting; 

namespace Application.ExtensionHelper.Test.Tests
{
    [TestClass]
    public class UnitTestingStringExtenion
    {
        [TestMethod]
        public void TestRemoveInnerSpaces()
        {
            string myString = "This is     string with  multiple   spaces in this paragraph. It      should remove all     unnecessary spaces  from the string.       ";
            string normalizedString = myString.TrimInnerSpaces();
        }

        [TestMethod]
        public void TestUrlEncoding()
        {
            string url = "https://www.google.com/search?q=url encode example";
            string normalizedString = url.UrlEncode();
        }
    }
}
