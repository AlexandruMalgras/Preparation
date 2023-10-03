using Arrays_and_Strings.Exercises;

namespace Arrays_and_Strings_Unit_Test
{
    public class OneWayUnitTest
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                "pale",
                "ple",
                true
            };

            yield return new object[]
            {
                "pale",
                "pales",
                true
            };

            yield return new object[]
            {
                "",
                "",
                true
            };

            yield return new object[]
            {
                "pale",
                "bale",
                true
            };

            yield return new object[]
            {
                "pale",
                "palm",
                true
            };

            yield return new object[]
            {
                "ple",
                "pale",
                true
            };

            yield return new object[]
            {
                "pale",
                "ale",
                true
            };

            yield return new object[]
            {
                "pale",
                "pal",
                true
            };

            yield return new object[]
            {
                "pale",
                "alk",
                false
            };

            yield return new object[]
            {
                "pale",
                "bake",
                false
            };

            yield return new object[]
            {
                "pale",
                "abcd",
                false
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void OneWayWithCheck(string a, string b, bool expected)
        {
            bool result = OneWay.OneWayWithCheck(a, b);

            Assert.Equal(expected, result);
        }
    }
}
