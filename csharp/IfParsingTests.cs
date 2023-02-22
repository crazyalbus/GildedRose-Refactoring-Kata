using System;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using NUnit.Framework;
// ReSharper disable EqualExpressionComparison
// ReSharper disable ConditionIsAlwaysTrueOrFalse

namespace csharp
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class IfParsingTests
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
            bool result1 = false;
            bool result2 = false;
            if(colour1 == colour1 && colour2 == colour2)
            {
                result1 = true;
            }
            if(true)
            {
                result2 = true;
            }
            return $"{result1 && result2}";
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
            bool result1 = false;
            bool result2 = false;
            if(colour1 == "green" && colour1 == "blue")
            {
                result1 = true;
            }
            if(false)
            {
                result2 = true;
            }
            return $"{result1 && result2}";
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
            bool result1 = false;
            bool result2 = false;
            if(colour1 != "green" && colour2 != "blue")
            {
                result1 = true;
            }
            if(!(colour1 == "green" || colour2 == "blue"))
            {
                result2 = true;
            }
            return $"{result1 && result2}";
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
            bool result1 = false;
            bool result2 = false;
            if(!(colour1 != "green" && colour2 != "blue"))
            {
                result1 = true;
            }
            if(colour1 == "green" || colour2 == "blue")
            {
                result2 = true;
            }
            return $"{result1 && result2}";
        }

        [Test]
        public void IfParsingEx5()
        {
            CombinationApprovals.VerifyAllCombinations(
                DoIfParsingEx5,
                new String[] { "green", "blue" },
                new String[] { "green", "blue" });
        }

        private String DoIfParsingEx5(String colour1, String colour2)
        {
            bool result1 = false;
            bool result2 = false;
            if(!(colour1 == "green" && colour2 == "blue"))
            {
                result1 = true;
            }
            if(colour1 != "green" || colour2 != "blue")
            {
                result2 = true;
            }
            return $"{result1 && result2}";
        }

        [Test]
        public void IfParsingTestOtherGuesses()
        {
            CombinationApprovals.VerifyAllCombinations(
                DoIfParsingTestOtherGuesses,
                new String[] { "green", "blue" },
                new String[] { "green", "blue" });
        }

        private String DoIfParsingTestOtherGuesses(String colour1, String colour2)
        {
            bool result1 = false;
            bool result2 = false;
            if(true)
            {
                result1 = true;
            }
            if(true)
            {
                result2 = true;
            }
            return $"{result1 && result2}";
        }
    }
}
