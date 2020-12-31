using NUnit.Framework;
using MyGit;
using System.IO;
using System.Linq;

namespace tests
{
    public class VersionControlSystemTests
    {
        private readonly string TestingPath =
            Path.Combine(Directory.GetCurrentDirectory(), "testing");
        IVersionControlSystem vcs = null;

        private static void DeleteIfExists(string path)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
        }

        [SetUp]
        public void Setup()
        {
            DeleteIfExists(TestingPath);
            vcs = new VersionControlSystem(TestingPath);
        }

        [TearDown]
        public void TearDown()
        {
            DeleteIfExists(TestingPath);
        }

        [Test]
        public void Test0()
        {
            vcs.Init();

            Assert.IsTrue(
                Directory.Exists(
                    Path.Combine(TestingPath, VersionControlSystem.VcsRootDirectoryName)));
        }

        [Test]
        public void Test1()
        {
            vcs.Init();

            var branches = vcs.Branches();
            Assert.AreEqual(1, branches.Count());
            Assert.AreEqual("master", branches.First().Name);
        }
    }
}
