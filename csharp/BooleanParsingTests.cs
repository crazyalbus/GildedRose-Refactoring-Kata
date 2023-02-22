using System;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace csharp
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class BooleanParsingTests
    {
        [Test]
        public void BooleanParsingEx1()
        {
            CombinationApprovals.VerifyAllCombinations(
                DoBooleanParsingEx1,
                new String[] { "green", "blue" },
                new String[] { "green", "blue" });
        }

        private String DoBooleanParsingEx1(String colour1, String colour2)
        {
            bool result1 = (colour1 == colour1 && colour2 == colour2);
            bool result2 = true;
            return $"{result1 == result2}";
        }

        [Test]
        public void BooleanParsingEx2()
        {
            CombinationApprovals.VerifyAllCombinations(
                DoBooleanParsingEx2,
                new String[] { "green", "blue" },
                new String[] { "green", "blue" });
        }

        private String DoBooleanParsingEx2(String colour1, String colour2)
        {
            bool result1 = (colour1 == "green" && colour1 == "blue");
            bool result2 = false;
            return $"{result1 == result2}";
        }

        [Test]
        public void BooleanParsingEx3()
        {
            CombinationApprovals.VerifyAllCombinations(
                DoBooleanParsingEx3,
                new String[] { "green", "blue" },
                new String[] { "green", "blue" });
        }

        private String DoBooleanParsingEx3(String colour1, String colour2)
        {
            bool result1 = (colour1 != "green" && colour2 != "blue");
            bool result2 = !(colour1 == "green" || colour2 == "blue");
            return $"{result1 == result2}";
        }

        [Test]
        public void BooleanParsingEx4()
        {
            CombinationApprovals.VerifyAllCombinations(
                DoBooleanParsingEx4,
                new String[] { "green", "blue" },
                new String[] { "green", "blue" });
        }

        private String DoBooleanParsingEx4(String colour1, String colour2)
        {
            bool result1 = !(colour1 != "green" && colour2 != "blue");
            bool result2 = (colour1 == "green" || colour2 == "blue");
            return $"{result1 == result2}";
        }

        [Test]
        public void BooleanParsingEx5()
        {
            CombinationApprovals.VerifyAllCombinations(
                DoBooleanParsingEx5,
                new String[] { "green", "blue" },
                new String[] { "green", "blue" });
        }

        private String DoBooleanParsingEx5(String colour1, String colour2)
        {
            bool result1 = !(colour1 == "green" && colour2 == "blue");
            bool result2 = (colour1 != "green") || (colour2 != "blue");
            return $"{result1 == result2}";
        }

        [Test]
        public void BooleanParsingEx6()
        {
            CombinationApprovals.VerifyAllCombinations(
                DoBooleanParsingEx6,
                new String[] { "green", "blue" },
                new String[] { "green", "blue" });
        }

        private String DoBooleanParsingEx6(String colour1, String colour2)
        {
            bool result1 = !(colour1 == "green" || colour2 == "blue");
            bool result2 = (colour1 != "green") && (colour2 != "blue");
            return $"{result1 == result2}";
        }

        [Test]
        public void BooleanParsingTestOtherGuesses()
        {
            CombinationApprovals.VerifyAllCombinations(
                DoBooleanParsingTestOtherGuesses,
                new String[] { "green", "blue" },
                new String[] { "green", "blue" });
        }

        private String DoBooleanParsingTestOtherGuesses(String colour1, String colour2)
        {
            bool result1 = true;
            bool result2 = true;
            return $"{result1 == result2}";
        }
    }
}
