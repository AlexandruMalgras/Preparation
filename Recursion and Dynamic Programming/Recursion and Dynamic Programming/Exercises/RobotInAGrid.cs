using System.Drawing;

namespace Recursion_and_Dynamic_Programming.Exercises
{
    /*
     * Imagine a robot sitting on the upper left corner of grid with r rows and c columns.
     * The robot can only move in two directions, right and down, but certain cells are "off limits"
     * such that the robot cannot step on them. Design an algorithm to find a path for the robot from
     * the top left to the bottom right.
     */
    public static class RobotInAGrid
    {
        /*
         * We recursively check the points in the grid starting from the bottom right.
         * We check if the top point and left point are available.
         */
        public static List<Point> RobotInAGridWithRecursion(List<List<bool>> grid)
        {
            if (grid.Count == 0 || grid == null) return null;

            List<Point> path = new List<Point>();

            if (IsAvailable(grid, grid.Count - 1, grid[0].Count - 1, path))
            {
                return path;
            }

            return null;
        }

        private static bool IsAvailable(List<List<bool>> grid, int row, int col, List<Point> path)
        {
            // Check if we are out of bounds or the current point is set to false
            if (row < 0 || col < 0 || !grid[row][col]) return false;

            // Boolean to see if we reached the start of the grid.
            bool isAtOrigin = (row == 0) && (col == 0);

            // Check if we can go up from the current point.
            bool canGoUp = IsAvailable(grid, row - 1, col, path);

            // Check if we can go left from the current point only if we can't go up to return one path at the end of the algorithm.
            bool canGoLeft = false;

            if (!canGoUp)
            {
                canGoLeft = IsAvailable(grid, row, col - 1, path);
            }

            // If any of the booleans above are true add the point to the list of points.
            if (isAtOrigin || canGoUp || canGoLeft)
            {
                path.Add(new Point(row, col));
                return true;
            }

            return false;
        }

        /*
         * The same approach as the previous method, however we cache all the points that failed to not check them again.
         */
        public static List<Point> RobotInAGridWithMemoization(List<List<bool>> grid)
        {
            if (grid.Count == 0 || grid == null) return null;

            List<Point> path = new List<Point>();
            HashSet<Point> fails = new HashSet<Point>();

            if (IsAvailable(grid, grid.Count - 1, grid[0].Count - 1, path, fails))
            {
                return path;
            }

            return null;
        }

        private static bool IsAvailable(List<List<bool>> grid, int row, int col, List<Point> path, HashSet<Point> fails)
        {
            // Check if we are out of bounds or the current point is set to false
            if (row < 0 || col < 0 || !grid[row][col]) return false;

            // Boolean to see if we reached the start of the grid.
            bool isAtOrigin = (row == 0) && (col == 0);

            Point point = new Point(row, col);

            // Stop if the set already contains the failed point.
            if (fails.Contains(point)) return false;

            // Check if we can go up from the current point.
            bool canGoUp = IsAvailable(grid, row - 1, col, path, fails);

            // Check if we can go left from the current point only if we can't go up to return one path at the end of the algorithm.
            bool canGoLeft = false;

            if (!canGoUp)
            {
                canGoLeft = IsAvailable(grid, row, col - 1, path, fails);
            }

            // If any of the booleans above are true add the point to the list of points.
            if (isAtOrigin || canGoUp || canGoLeft)
            {
                path.Add(point);
                return true;
            }

            // Cache the result
            fails.Add(point);
            return false;
        }
    }
}
