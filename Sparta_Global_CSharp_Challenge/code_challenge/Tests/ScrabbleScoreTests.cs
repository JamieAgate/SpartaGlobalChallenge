using NUnit.Framework;
using code_challenge.Challenges;
namespace code_challenge.Tests
{
    [TestFixture()]
    public class ScrabbleScoreTests
    {
        ScrabbleScoreCalculator ScrabbleScoreCalculator = new ScrabbleScoreCalculator();

        [Test()]
        public void ScrabbleScoreTest()
        {
            Assert.AreEqual(12, ScrabbleScoreCalculator.WordScoreCheck("zoo"));
            Assert.AreEqual(15, ScrabbleScoreCalculator.WordScoreCheck("joke"));
        }
    }
}
