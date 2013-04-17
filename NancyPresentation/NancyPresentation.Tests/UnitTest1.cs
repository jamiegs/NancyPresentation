using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy;
using Nancy.Testing;

namespace NancyPresentation.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnsOkStatusCodeWhenExists()
        {
            var bs = new DefaultNancyBootstrapper();
            var browser = new Browser(bs);
            
            var result = browser.Get("/user", 
                with => { 
                    with.HttpRequest();
            });

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }
    }
}
