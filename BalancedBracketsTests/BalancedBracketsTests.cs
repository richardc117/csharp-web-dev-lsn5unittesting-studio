using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        //[TestMethod]
        //public void EmptyTest()
        //{
        //    Assert.AreEqual(true, true);
        //}

        [TestMethod]
        public void CheckIfBracketsAreInTheRightOrder()
        {
            string testString = "]test[";

            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void CheckIfEvenNumberofOpeningAndClosingBrackets()
        {
            string testString = "[testString][";

            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void ReturnTrueIfStringIsEmpty()
        {
            string testString = "";
            
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void ReturnsTrueRegardlessOfBracketPlacement()
        {
            string testString = "Test[String]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void ReturnsTrueIfWordwithNoBracket()
        {
            string testString = "Test";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void AcceptsWhiteSpaceWithinBracket()
        {
            string testString = "[            ]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void AcceptsWhiteSpace()
        {
            string testString = "            ";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void AcceptsSpecialChars()
        {
            string testString = "$%^[^&]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void AccountsForMultiplebracketPairs()
        {
            string testString = "Test[String][idv]hin";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void RejectsUnorderedMultipleBracketpairs()
        {
            string testString = "test[]te]s[t";
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void AcceptsProperlyNestedBrckets()
        {
            string testString = "[[[[]]]]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void RejectsImproperlyNestedBrckets()
        {
            string testString = "[[[[[]]]]";
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testString));
        }



    }
}
