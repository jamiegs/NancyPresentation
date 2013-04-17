using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy;
using Nancy.Responses.Negotiation;
using Nancy.Testing;

namespace NancyPresentation.Tests
{
    [TestClass]
    public class UserUnitTests
    {
        /// <summary>
        /// Tests that a 200 is returned when visiting a page that doesn't exist.
        /// </summary>
        [TestMethod]
        public void ReturnsOkStatusCodeWhenExists()
        {
            var bs = new TestBootStrapper();
            var browser = new Browser(bs);

            var result = browser.Get("/users/", with => with.HttpRequest());

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }

        /// <summary>
        /// Tests that a 404 is returned when visiting a page that doesn't exist.
        /// </summary>
        [TestMethod]
        public void Returns404StatusCodeWhenDoesntExists()
        {
            var bs = new TestBootStrapper();
            var browser = new Browser(bs);

            var result = browser.Get("/usersa/", with => with.HttpRequest());

            Assert.AreEqual(HttpStatusCode.NotFound, result.StatusCode);
        }

        /// <summary>
        /// Tests that Json is returned when accepting Json.
        /// </summary>
        [TestMethod]
        public void ReturnsJson()
        {
            var bs = new TestBootStrapper();
            var browser = new Browser(bs);

            var result = browser.Get("/users/1/", with =>
            {
                with.HttpRequest();
                with.Accept(new MediaRange { Subtype = "json", Type = "application" });
            });


            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual("application/json", result.Context.Response.ContentType);
        }

        /// <summary>
        /// Tests that Bob is returned when requesting user 1.
        /// </summary>
        [TestMethod]
        public void ReturnsBob()
        {
            var bs = new TestBootStrapper();
            var browser = new Browser(bs);

            var result = browser.Get("/users/1/", with => with.HttpRequest());

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);

            result.Body["body p:nth-of-type(2)"].ShouldExist().And.ShouldContain("First Name: Bob");
        }
    }
}
