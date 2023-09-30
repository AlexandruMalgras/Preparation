using Arrays_and_Strings.Exercises;

namespace Arrays_and_Strings_Unit_Test
{
    public class IsUniqueUnitTest
    {
        [Theory]
        [InlineData("hello", false)]
        [InlineData("world", true)]
        [InlineData("", true)]
        [InlineData("a", true)]
        [InlineData("!@#$%^&*()", true)]
        [InlineData("!@#$%^&*()@", false)]
        [InlineData("Aa", true)]
        [InlineData("Analog", true)]
        [InlineData("is me you", false)]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ/.,';][=-0987654321``", false)]
        public void IsUniqueBruteForceTest(string input, bool expectedResult)
        {
            bool isUnique = IsUnique.IsUniqueBruteForce(input);

            Assert.Equal(expectedResult, isUnique);
        }

        [Theory]
        [InlineData("hello", false)]
        [InlineData("world", true)]
        [InlineData("", true)]
        [InlineData("a", true)]
        [InlineData("!@#$%^&*()", true)]
        [InlineData("!@#$%^&*()@", false)]
        [InlineData("Aa", true)]
        [InlineData("Analog", true)]
        [InlineData("is me you", false)]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ/.,';][=-0987654321``", false)]
        public void IsUniqueSortTest(string input, bool expectedResult)
        {
            bool isUnique = IsUnique.IsUniqueWithSorting(input);

            Assert.Equal(expectedResult, isUnique);
        }

        [Theory]
        [InlineData("hello", false)]
        [InlineData("world", true)]
        [InlineData("", true)]
        [InlineData("a", true)]
        [InlineData("!@#$%^&*()", true)]
        [InlineData("!@#$%^&*()@", false)]
        [InlineData("Aa", true)]
        [InlineData("Analog", true)]
        [InlineData("is me you", false)]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ/.,';][=-0987654321``", false)]
        public void IsUniqueSwitchTest(string input, bool expectedResult)
        {
            bool isUnique = IsUnique.IsUniqueSwitchFlip(input);

            Assert.Equal(expectedResult, isUnique);
        }

        [Theory]
        [InlineData("hello", false)]
        [InlineData("world", true)]
        [InlineData("", true)]
        [InlineData("a", true)]
        [InlineData("!@#$%^&*()", true)]
        [InlineData("!@#$%^&*()@", false)]
        [InlineData("Aa", true)]
        [InlineData("Analog", true)]
        [InlineData("is me you", false)]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ/.,';][=-0987654321``", false)]
        public void IsUniqueSetsTest(string input, bool expectedResult)
        {
            bool isUnique = IsUnique.IsUniqueWithSets(input);

            Assert.Equal(expectedResult, isUnique);
        }
    }
}