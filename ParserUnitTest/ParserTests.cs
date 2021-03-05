using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser;

namespace ParserUnitTest
{
    [TestClass]
    public class ParserTests
    {
        [TestMethod]
        public void TestEmpyString()
        {
            var parsed = Parser.Parse("");
            Assert.AreEqual(parsed.Count, 0);
        }

        [TestMethod]
        public void TestNullString()
        {
            var parsed = Parser.Parse(null);
            Assert.AreEqual(parsed.Count, 0);
        }

        [TestMethod]
        public void TestSimpleString()
        {
            var parsed = Parser.Parse("so many                words and again-many many words");

            Assert.AreEqual(parsed.Count, 5);

            Assert.AreEqual(parsed["many"], 2);

            Assert.AreEqual(parsed["words"], 2);

            Assert.AreEqual(parsed["so"], 1);


        }

        [TestMethod]
        public void TestComplexString()
        {
            var text = "so many:                words and again-many many words," + Environment.NewLine +
                "here is another line:" + Environment.NewLine + "and the third -  line!";
            var parsed = Parser.Parse(text);

            Assert.AreEqual(parsed.Count, 11);

            Assert.AreEqual(parsed["words"], 2);

            Assert.AreEqual(parsed["many"], 2);

            Assert.AreEqual(parsed["line"], 2);

            Assert.AreEqual(parsed["so"], 1);


        }
    }
}
