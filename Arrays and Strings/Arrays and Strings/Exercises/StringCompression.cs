using System.Text;

namespace Arrays_and_Strings.Exercises
{
    /*
     * Implement a method to perform basic string compression using the counts of repeated characters.
     * For example, the string aabcccccaaa would become a2b1c5a3. If the "compressed" string would not
     * become smaller than the original string, your method should return the original string. You can
     * assume the string has only uppercase and lowercase letters (a-z).
     */
    public class StringCompression
    {
        /*
         * We can continuously count as we go through the array, but with some rules to apply.
         */
        public static string StringCompressionContinuous(string input)
        {
            // The way the algorithm is built would crash if we don't instantly return if the input is null.
            if (input == "") return input;

            StringBuilder output = new StringBuilder();

            char current = input[0];
            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == current)
                {
                    count++;
                }
                else
                {
                    output.Append(current);
                    output.Append(count);

                    current = input[i];
                    count = 1;
                }
            }

            /* 
             * Update the last iteration of the algorithm as there is no next character to check at the end.
             * It also appends the character and the count when the input length is 1.
             */
            output.Append(current);
            output.Append(count);

            return output.Length > input.Length ? input : output.ToString();
        }
    }
}
