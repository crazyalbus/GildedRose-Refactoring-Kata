<<<<<<< HEAD:csharpcore/ApprovalTest.cs
﻿using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;
=======
﻿
using GildedRoseKata;

using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using VerifyXunit;

using Xunit;
>>>>>>> csharp-approval-fixes:csharpcore-Verify.xunit/GildedRoseTests/ApprovalTest.cs

namespace GildedRoseTests
{
<<<<<<< HEAD:csharpcore/ApprovalTest.cs
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class ApprovalTest
    {
        [Test]
        public void ThirtyDays()
=======
    [UsesVerify]
    public class ApprovalTest
    {
        [Fact]
        public Task ThirtyDays()
>>>>>>> csharp-approval-fixes:csharpcore-Verify.xunit/GildedRoseTests/ApprovalTest.cs
        {
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            var output = fakeoutput.ToString();

            return Verifier.Verify(output);
        }
    }
}
