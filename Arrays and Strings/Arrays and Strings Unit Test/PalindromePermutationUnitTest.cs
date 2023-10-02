using Arrays_and_Strings.Exercises;

namespace Arrays_and_Strings_Unit_Test
{
    public class PalindromePermutationUnitTest
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                "Tact Coa",
                true
            };

            yield return new object[]
            {
                "Able was I ere I saw Elba",
                true
            };

            yield return new object[]
            {
                "hello",
                false
            };

            yield return new object[]
            {
                "Able was I",
                false
            };

            yield return new object[]
            {
                "",
                true
            };

            yield return new object[]
            {
                "aabbcd",
                false
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void PalindromePermutationWithDictionaryTest(string input, bool expected)
        {
            bool result = PalindromePermutation.PalindromePermutationWithDictionary(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void PalindromePermutationWithSortingTest(string input, bool expected)
        {
            bool result = PalindromePermutation.PalindromePermutationWithSorting(input);

            Assert.Equal(expected, result);
        }
    }
}
