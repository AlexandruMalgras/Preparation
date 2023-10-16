using Recursion_and_Dynamic_Programming.Exercises;
using System.Drawing;

namespace Recursion_and_Dynamic_Programming_Unit_Test
{
    public class RobotInAGridUnitTest
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new List<List<bool>>() 
                { 
                    new List<bool>() { true, false, true },
                    new List<bool>() { true, true, false },
                    new List<bool>() { true, true, true }
                },
                true
            };

            yield return new object[]
            {
                new List<List<bool>>()
                {
                    new List<bool>() { true, false, true },
                    new List<bool>() { true, true, false },
                    new List<bool>() { true, false, true }
                },
                false
            };

            yield return new object[]
            {
                new List<List<bool>>()
                {
                    new List<bool>() { true, false, true },
                    new List<bool>() { false, true, false },
                    new List<bool>() { true, true, true }
                },
                false
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void RobotInAGridWithRecursionTest(List<List<bool>> grid, bool expected)
        {
            List<Point> path = RobotInAGrid.RobotInAGridWithRecursion(grid);

            bool result = path != null;

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void RobotInAGridWithMemoizationTest(List<List<bool>> grid, bool expected)
        {
            List<Point> path = RobotInAGrid.RobotInAGridWithMemoization(grid);

            bool result = path != null;

            Assert.Equal(expected, result);
        }
    }
}
