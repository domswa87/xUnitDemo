using ClassFixture;
using System;
using Xunit;
using Xunit.Abstractions;

namespace ClassFixtureTests
{
    // different instance of class RandomNumberGenerator
    public class ClassFixtureTests_DifferentNumbers 
    {
        private readonly RandomNumberGenerator randomNumberGenerator;
        private readonly ITestOutputHelper testOutputHelper;

        public ClassFixtureTests_DifferentNumbers(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            randomNumberGenerator = new RandomNumberGenerator();
        }

        [Fact]
        public void Test1()
        {
            int number = randomNumberGenerator.RandomNumber;
            testOutputHelper.WriteLine($"Test 1 number is: {randomNumberGenerator.RandomNumber}");
        }

        [Fact]
        public void Test2()
        {
            int number = randomNumberGenerator.RandomNumber;
            testOutputHelper.WriteLine($"Test 2 number is: {randomNumberGenerator.RandomNumber}");
        }
    }



    // the same instance of class RandomNumberGenerator
    public class ClassFixtureTests_TheSameNumbers : IClassFixture<RandomNumberGenerator>
    {
        private readonly RandomNumberGenerator randomNumberGenerator;
        private readonly ITestOutputHelper testOutputHelper;

        public ClassFixtureTests_TheSameNumbers(ITestOutputHelper testOutputHelper, RandomNumberGenerator randomNumberGenerator)
        {
            this.testOutputHelper = testOutputHelper;
            this.randomNumberGenerator = randomNumberGenerator;
        }

        [Fact]
        public void Test1()
        {
            int number = randomNumberGenerator.RandomNumber;
            testOutputHelper.WriteLine($"Test1 number is: {randomNumberGenerator.RandomNumber}");
        }

        [Fact]
        public void Test2()
        {
            int number = randomNumberGenerator.RandomNumber;
            testOutputHelper.WriteLine($"Test2 number is: {randomNumberGenerator.RandomNumber}");
        }
    }
}
