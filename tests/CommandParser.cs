using NUnit.Framework;
using MyGit;

namespace tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test0()
        {
            Assert.Catch(() => Program.ParseCommand(new string[1] { "help" }));
        }

        [Test]
        public void Test1()
        {
            Assert.IsNull(Program.ParseCommand(new string[1] { "--help" }));
            Assert.IsNull(Program.ParseCommand(new string[1] { "-h" }));
        }

        [Test]
        public void Test2()
        {
            var command = Program.ParseCommand(new string[1] { "init" });
            Assert.IsNotNull(command);
            Assert.IsTrue(command is InitCommand);
        }
    }
}