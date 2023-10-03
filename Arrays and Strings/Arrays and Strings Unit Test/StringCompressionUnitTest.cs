using Arrays_and_Strings.Exercises;

namespace Arrays_and_Strings_Unit_Test
{
    public class StringCompressionUnitTest
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                 "aabcccccaaa",
                 "a2b1c5a3"
            };

            yield return new object[]
            {
                "",
                ""
            };

            yield return new object[]
            {
                "a",
                "a"
            };

            yield return new object[]
            {
                "aaaaaa",
                "a6"
            };

            yield return new object[]
            {
                "AAAbbbCCC",
                "A3b3C3"
            };

            yield return new object[]
            {
                "AAbbCC",
                "A2b2C2"
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void StringCompressionWithContinuousTest(string input, string expected)
        {
            string result = StringCompression.StringCompressionContinuous(input);

            Assert.Equal(expected, result);
        }
    }
}
