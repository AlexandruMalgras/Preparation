namespace Arrays_and_Strings.Exercises
{
    /*
     * There are three types of edits that can be performed on strings: insert a character, remove a character, or replace
     * a character. Given two strings, write a function to check if they are one edit (or zero edits) away.
     */
    public class OneWay
    {
        /*
         * One approach is to split the algorithm in half.
         * First case when the strings have the same length we check for the differences.
         * Second case when the strings have different lengths (up to 1 difference) we check for insertion counts and differences.
         */
        public static bool OneWayWithCheck(string a, string b)
        {
            // Check the length.
            if (Math.Abs(a.Length - b.Length) > 1) return false;

            if (a.Length == b.Length)
            {
                if (!EqualityCheck(a, b)) return false;

                return true;
            }

            if (!NonEqualityCheck(a, b)) return false;

            return true;
        }

        private static bool EqualityCheck(string a, string b)
        {
            int countChanges = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) countChanges++;

                if (countChanges > 1) return false;
            }

            return true;
        }

        private static bool NonEqualityCheck(string a, string b)
        {
            string longest = a.Length > b.Length ? a : b;
            string shortest = a.Length > b.Length ? b : a;

            int modifier = 0;

            int countChanges = 0;

            for (int i = 0; i < longest.Length; i++)
            {
                if (modifier == 0 && i == longest.Length - 1)
                {
                    modifier++;
                }

                if (longest[i] != shortest[i - modifier])
                {
                    countChanges++;
                    modifier++;
                }

                if (countChanges > 1) return false;
            }

            return true;
        }
    }
}
