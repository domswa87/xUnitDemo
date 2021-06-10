using Methods;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Methods.Tests
{
    public class MethodsTests
    {
        // Fact properties
        [Fact(DisplayName = "MyTest", Skip = "I want skip this test", Timeout = 100)]
        public void AddNumbersTest()
        {
            Assert.True(false, "This test needs an implementation");
        }


        // InlineData
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(3, 3, 6)]
        [InlineData(1, 2, 5)]
        public void AddNumbersTest_InputInlineData_ResultAsExpected(int number1, int number2, int expectedResult)
        {
            int actualResult = Methods.AddNumbers(number1, number2);
            Assert.Equal(expectedResult, actualResult);
        }


        // MemberData
        [Theory]
        [InlineData(3, 3,"result: ", "result: 33")]
        [MemberData(nameof(AddNumbersParams))]
        public void AddNumbersAsTextTest_InputMemberData_ResultAsExpected(int number1, int number2, string text, string expectedResult)
        {
            string actualResult = Methods.AddNumbersWithText(number1, number2, text);
            Assert.Equal(expectedResult, actualResult);
        }

        public static IEnumerable<object[]> AddNumbersParams()
        {
            yield return new object[] { 1, 2, "result: ", "result: 12" };
            yield return new object[] { 2, 2, "result: ", "result: 22" };
            yield return new object[] { 5, 5, "result: ", "resultt: 55" };
        }

        // ClassData
        [Theory]
        [ClassData(typeof(TestParametersClass))]
        public void AddsManyNumbers_InputClassData_ResultAsExpected(int expectedResult, params int[] numbers)
        {
                int actualResult = Methods.AddsManyNumbers(numbers);
                Assert.Equal(expectedResult, actualResult);
        }

        // Exception
        [Fact()]
        public void DivideNumbersTest_Input0_ThrowNullReferenceException()
        {
            int number1 = 0;
            int number2 = 0;
            Assert.Throws<NullReferenceException>(() => Methods.DivideNumbers(number1, number2));
        }

        // Exception
        [Fact()]
        public void DivideNumbersTest_Input0_ThrowDivideByZeroException()
        {
            int number1 = 0;
            int number2 = 0;
            Assert.Throws<DivideByZeroException>(() => Methods.DivideNumbers(number1, number2));
        }

    }




    public class TestParametersClass : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 3, new int[] { 1, 1, 1 }};
            yield return new object[] { 5, new int[] { 2, 2, 1 }};
            yield return new object[] { 7, new int[] { 2, 2, 2 }};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}