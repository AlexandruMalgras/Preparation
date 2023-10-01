using Arrays_and_Strings.Exercises;

namespace Arrays_and_Strings_Unit_Test
{
    public class URLifyUnitTest
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new char[] { 'M', 'r', ' ', 'J', 'o', 'h', 'n', ' ', 'S', 'm', 'i', 't', 'h', '\0', '\0', '\0', '\0' },
                new char[] { 'M', 'r', '%', '2', '0', 'J', 'o', 'h', 'n', '%', '2', '0', 'S', 'm', 'i', 't', 'h' }
            };

            yield return new object[]
            {
                new char[] { ' ', 'a', ' ', 'b', ' ', 'c', ' ', 'd', ' ', 'e', ' ', 'f', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0' },
                new char[] { '%', '2', '0', 'a', '%', '2', '0', 'b', '%', '2', '0', 'c', '%', '2', '0', 'd', '%', '2', '0', 'e', '%', '2', '0', 'f' }
            };

            yield return new object[]
            {
                new char[] { 'a', 'b', 'c' },
                new char[] { 'a', 'b', 'c' }
            };

            yield return new object[]
            {
                new char[] { ' ', '\0', '\0' },
                new char[] { '%', '2', '0' }
            };

            yield return new object[]
            {
                new char[0],
                new char[0]
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void URLifyBackwardsTest(char[] input, char[] result)
        {
            URLify.URLifyBackwards(input);

            for (int i = 0; i < input.Length; i++)
            {
                Assert.Equal(input[i], result[i]);
            }
        }
    }
}
