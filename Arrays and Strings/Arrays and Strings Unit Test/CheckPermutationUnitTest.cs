using Arrays_and_Strings.Exercises;

namespace Arrays_and_Strings_Unit_Test
{
    public class CheckPermutationUnitTest
    {
        [Theory]
        [InlineData("", "", true)]
        [InlineData("", "abc", false)]
        [InlineData("listen", "silent", true)]
        [InlineData("lissen", "silent", false)]
        [InlineData("hello", "world", false)]
        [InlineData("abc", "def", false)]
        [InlineData("abc@123", "321@cba", true)]
        [InlineData("Abc", "abc", false)]
        public void CheckPermutationWithSortingTest(string first, string second, bool expectedResult)
        {
            bool checkPermutation = CheckPermutation.CheckPermutationWithSorting(first, second);

            Assert.Equal(expectedResult, checkPermutation);
        }

        [Theory]
        [InlineData("", "", true)]
        [InlineData("", "abc", false)]
        [InlineData("listen", "silent", true)]
        [InlineData("lissen", "silent", false)]
        [InlineData("hello", "world", false)]
        [InlineData("abc", "def", false)]
        [InlineData("abc@123", "321@cba", true)]
        [InlineData("Abc", "abc", false)]
        public void CheckPermutationWithDictionaryTest(string first, string second, bool expectedResult)
        {
            bool checkPermutation = CheckPermutation.CheckPermutationWithDictionary(first, second);

            Assert.Equal(expectedResult, checkPermutation);
        }
    }
}
