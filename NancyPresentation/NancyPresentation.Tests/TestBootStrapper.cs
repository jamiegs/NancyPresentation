using System;
using System.IO;
using Nancy;
using Nancy.Testing.Fakes;
using Nancy.Testing;

namespace NancyPresentation.Tests
{
    public class TestBootStrapper : CustomBootstrapper
    {
        protected override IRootPathProvider RootPathProvider
        {
            get
            {
                var assemblyFilePath =
                    new Uri(typeof(CustomBootstrapper).Assembly.CodeBase).LocalPath;

                var assemblyPath =
                    Path.GetDirectoryName(assemblyFilePath);

                var rootPath = PathHelper.GetParent(assemblyPath, 3);

                rootPath = Path.Combine(rootPath, @"NancyPresentation");

                FakeRootPathProvider.RootPath = rootPath;

                return new FakeRootPathProvider();
            }
        }
    }
}
