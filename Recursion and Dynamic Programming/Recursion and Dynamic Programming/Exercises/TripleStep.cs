namespace Recursion_and_Dynamic_Programming.Exercises
{
    /*
     * A child is running up a staircase with n steps and can hop either 1 step, 2 steps, or 3 steps at a time.
     * Implement a method to count how many possible ways the child can run up the stairs.
     */
    public static class TripleStep
    {
        // Using recursive approach.
        public static int TripleStepWithRecursion(int n)
        {
            if (n == 0) return 1;
            if (n < 0) return 0;

            return TripleStepWithRecursion(n - 1) + TripleStepWithRecursion(n - 2) + TripleStepWithRecursion(n - 3);
        }

        // Using dynamic programming.
        public static int TripleStepWithMemoitization(int n)
        {
            if (n <= 1) return 1;

            int[] memos = new int[n + 1];

            // Establish the base cases
            memos[0] = 1; // We are already at the top, return 1.
            memos[1] = 1; // Can only do 1 step of 1.
            memos[2] = 2; // Can either do 2 steps of 1 or 1 step of 2.

            // Calculate when n is higher than 2 using the base cases
            for (int i = 3; i < memos.Length; i++)
            {
                memos[i] = memos[i - 1] + memos[i - 2] + memos[i - 3];
            }

            // return the element at the highest index in the array.
            return memos[n];
        }
    }
}
