using Nancy;
using Nancy.Diagnostics;

namespace NancyPresentation
{
    public class CustomBootstrapper : DefaultNancyBootstrapper
    {
        protected override DiagnosticsConfiguration DiagnosticsConfiguration
        {
            // This just configures the password for the http://localhost":12345/_nancy page
            get { return new DiagnosticsConfiguration { Password = @"12345" }; }
        }
    }
}
