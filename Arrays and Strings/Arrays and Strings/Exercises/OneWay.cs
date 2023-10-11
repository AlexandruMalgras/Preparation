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
            // Check if the length is higher or equal than 2.
            if (Math.Abs(a.Length - b.Length) > 1) return false;

            // Execute the equality algorithm if the strings are equal.
            if (a.Length == b.Length)
            {
                if (!EqualityCheck(a, b)) return false;

                return true;
            }

            // Execute the nonequality algorithm if the strings are not equal.
            if (!NonEqualityCheck(a, b)) return false;

            return true;
        }

        private static bool EqualityCheck(string a, string b)
        {
            int countChanges = 0;

            // Check the occurance of different characters at the same index in the strings.
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) countChanges++;

                if (countChanges > 1) return false;
            }

            return true;
        }

        private static bool NonEqualityCheck(string a, string b)
        {
            // Establish which of the string is longer.
            string longest = a.Length > b.Length ? a : b;
            string shortest = a.Length > b.Length ? b : a;

            for (int i = 0; i < shortest.Length; i++)
            {
                // Since the strings already need 1 edit because of the nonequality, we stop at the first replacement needed.
                if (longest[i] != shortest[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
