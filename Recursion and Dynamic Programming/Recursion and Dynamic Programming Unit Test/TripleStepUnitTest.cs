using Recursion_and_Dynamic_Programming.Exercises;

namespace Recursion_and_Dynamic_Programming_Unit_Test
{
    public class TripleStepUnitTest
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                0,
                1
            };

            yield return new object[]
            {
                1,
                1
            };

            yield return new object[]
            {
                2,
                2
            };

            yield return new object[]
            {
                3,
                4
            };

            yield return new object[]
            {
                4,
                7
            };

            yield return new object[]
            {
                5,
                13
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TripleStepRecursionTest(int n, int expected)
        {
            int ways = TripleStep.TripleStepWithRecursion(n);

            Assert.Equal(expected, ways);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TripleStepMemoitizationTest(int n, int expected)
        {
            int ways = TripleStep.TripleStepWithMemoitization(n);

            Assert.Equal(expected, ways);
        }
    }
}