using Codility_MaxCounters;

namespace Codility_MaxCountersTests
{
    public class SolutionTests
    {
        [Fact]
        public void Solution_Returns_CorrectCounters_ExampleCase()
        {
            // Arrange
            Solution solution = new Solution();
            int N = 5;
            int[] A = new int[] { 3, 4, 4, 6, 1, 4, 4 };

            // Act
            int[] result = solution.solution(N, A);

            // Assert
            Assert.Equal(new int[] { 3, 2, 2, 4, 2 }, result);
        }

        [Fact]
        public void Solution_Returns_EmptyArray_OutsideRange()
        {
            // Arrange
            Solution solution = new Solution();
            int N = 100001; // Outside allowed range
            int[] A = new int[] { 1, 2, 3 };

            // Act
            int[] result = solution.solution(N, A);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Solution_Returns_CorrectCounters_AllMaxOperations()
        {
            // Arrange
            Solution solution = new Solution();
            int N = 3;
            int[] A = new int[] { N + 1, N + 1, N + 1 }; // All max operations

            // Act
            int[] result = solution.solution(N, A);

            // Assert
            Assert.Equal(new int[] { 0, 0, 0 }, result);
        }
    }
}