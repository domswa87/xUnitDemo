using Xunit;
using CodeCoverade.MyFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCoverade.MyFolder.Tests
{
    public class MethodsTests
    {
        [Fact()]
        public void MultiplyBy2CoveredTest_Input2_Return4()
        {
            var actualResult = Methods.MultiplyBy2Covered(2);
            Assert.Equal(4, actualResult);
        }

        [Fact()]
        public void MultiplyBy10UncoveredTest()
        {
            Assert.True(false, "This test need implementation");

            //var actualResult = Methods.MultiplyBy10Uncovered(10);
            //Assert.Equal(100, actualResult);
        }

        [Fact()]
        public void MultiplyBy10UncoveredTest_MethodUncovered_TestFalseSoCodeUncovered()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void MultiplyBy10_MethodUncovered_TestTrueSoCodeCovered()
        {
            Assert.True(true, "This test needs an implementation");
        }
    }
}