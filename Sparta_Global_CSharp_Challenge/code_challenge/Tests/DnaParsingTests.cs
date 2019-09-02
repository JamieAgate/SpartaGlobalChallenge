using NUnit.Framework;
using System;
namespace code_challenge.Tests
{
    [TestFixture()]
    public class DnaParsingTests
    {
        DnaParsing dnaParsing = new DnaParsing();

        [Test()]
        public void TestDnaParsing()
        {
            Assert.AreEqual("20 12 17 21", dnaParsing.SequenceCount("AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC"));
            Assert.AreEqual("2 2 2 2", dnaParsing.SequenceCount("AAGGTTCC"));
        }
    }
}
