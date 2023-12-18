using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
 
        [Test]
        public void WhenAddEmployeeScores_ThenCorrectResult()
        {
            // Arrange
            var emp1 = new Employee("Jan", "Dêbski", 38);

            emp1.AddScore(7);
            emp1.AddScore(8);
            emp1.AddScore(1);

            // Act
            var result1 = emp1.Result;
            // Assert
            Assert.AreEqual(16, result1);
        }
        [Test]
        public void WhenAddEmployeeNegativeScores_ThenCorrectZeroResult()
        {
            // Arrange
            var emp2 = new Employee("Karol", "Grzyb", 42);

            emp2.AddScore(1);
            emp2.AddScore(-1);

            // Act
            var result2 = emp2.Result;
            // Assert
            Assert.AreEqual(0, result2);
        }
        [Test]
        public void WhenAddEmployeeNegativeScores_ThenCorrectNegativeResult()
        {
            // Arrange
            var emp3 = new Employee("Hanna", "Solska", 26);

            emp3.AddScore(10);
            emp3.AddScore(-1);
            emp3.AddScore(-10);

            // Act
            var result3 = emp3.Result;
            // Assert
            Assert.AreEqual(-1, result3);
        }


    }
}