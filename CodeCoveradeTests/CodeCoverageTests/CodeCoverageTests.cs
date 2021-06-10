using CodeCoverade.MyFolder;
using System;
using Xunit;

namespace CodeCoverageTests
{
    public class CodeCoverageTests
    {
        [Fact()]
        public void MultiplyBy1CoveredTest_Input10_Return10()
        {
            var actualResult = CodeCoverage.MultiplyBy1Covered(10);
            Assert.Equal(10, actualResult);
        }

        [Fact()]
        public void MultiplyBy0UncoveredTest()
        {
            //Uncovered
            Assert.True(false, "This test need implementation");

            //Covered
            //var actualResult = Methods.MultiplyBy0Uncovered(10);
            //Assert.Equal(0, actualResult);
        }

        [Fact()]
        public void MultiplyBy5HalfCoveredTest_HalfCovered()
        {
            int actualResult = CodeCoverage.MultiplyBy5HalfCovered(10, false);
            Assert.Equal(50, actualResult);
        }

        [Fact()]
        public void MultiplyBy10_TestTrueSoCodeCovered()
        {
            Assert.True(true, "Test result: True - So Code is covered");
        }

        [Fact()]
        public void MultiplyBy10_OneLineUncovered()
        {
            Assert.True(true, "This line is covered");
            Assert.True(true, "This line is covered");
            Assert.True(true, "This line is covered");
            Assert.False(true, "This line is uncovered");
        }

        [Fact()]
        public void MultiplyBy10_ThreeLinesUncovered()
        {
            Assert.True(true, "This line is covered");
            Assert.True(true, "This line is covered");
            Assert.True(true, "This line is covered");
            Assert.False(true, "This line is uncovered");
            Assert.False(true, "This line is uncovered");
            Assert.False(true, "This line is uncovered");
        }

        [Fact()]
        public void MultiplyBy10_4LinesUncovered()
        {
            Assert.True(true,  "covered");
            Assert.True(true,  "covered");
            Assert.False(true, "uncovered");
            Assert.True(true,  "uncovered");
            Assert.True(true,  "uncovered");
            Assert.True(true,  "uncovered");
        }
    }
}
