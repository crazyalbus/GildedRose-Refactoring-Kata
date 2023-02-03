using System;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace csharp
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class ApprovalTest
    {
        [Test]
        public void IfParsingEx1()
        {
            CombinationApprovals.VerifyAllCombinations(
                DoIfParsingEx1,
                new String[] { "green", "blue" },
                new String[] { "green", "blue" });
        }

        private String DoIfParsingEx1(String colour1, String colour2)
        {
            bool result1 = (colour1 == colour1 && colour2 == colour2);
            bool result2 = true;
            return $"{result1 == result2}";
        }

        [Test]
        public void IfParsingEx2()
        {
            CombinationApprovals.VerifyAllCombinations(
                DoIfParsingEx2,
                new String[] { "green", "blue" },
                new String[] { "green", "blue" });
        }

        private String DoIfParsingEx2(String colour1, String colour2)
        {
            bool result1 = (colour1 == "green" && colour1 == "blue");
            bool result2 = false;
            return $"{result1 == result2}";
        }

        [Test]
        public void IfParsingEx3()
        {
            CombinationApprovals.VerifyAllCombinations(
                DoIfParsingEx3,
                new String[] { "green", "blue" },
                new String[] { "green", "blue" });
        }

        private String DoIfParsingEx3(String colour1, String colour2)
        {
            bool result1 = (colour1 != "green" && colour2 != "blue");
            bool result2 = !(colour1 == "green" || colour2 == "blue");
            return $"{result1 == result2}";
        }

        [Test]
        public void IfParsingEx4()
        {
            CombinationApprovals.VerifyAllCombinations(
                DoIfParsingEx4,
                new String[] { "green", "blue" },
                new String[] { "green", "blue" });
        }

        private String DoIfParsingEx4(String colour1, String colour2)
        {
            bool result1 = !(colour1 != "green" && colour2 != "blue");
            bool result2 = (colour1 == "green" || colour2 == "blue");
            return $"{result1 == result2}";
        }
    }
}
