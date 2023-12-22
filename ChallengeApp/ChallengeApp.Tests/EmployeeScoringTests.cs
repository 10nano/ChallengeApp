using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
 
        [Test]
        public void WhenAddEmployeeScores_ThenCorrectMinimumValue()
        {
            // Arrange
            var employee = new Employee("Jan", "D�bski");

            employee.AddScore(3);
            employee.AddScore(0);
            employee.AddScore(1);

            // Act
            var statistics = employee.GetStatistics();
            // Assert
            Assert.AreEqual(0f, statistics.Min);
        }
        [Test]
        public void WhenAddEmployeeScores_ThenCorrectMaximumValue()
        {
            // Arrange
            var employee = new Employee("Karol", "Grzyb");

            employee.AddScore(3);
            employee.AddScore(0);
            employee.AddScore(1);

            // Act
            var statistics = employee.GetStatistics();
            // Assert
            Assert.AreEqual(3f, statistics.Max);
        }
        [Test]
        public void WhenAddEmployeeScores_ThenCorrectAverage()
        {
            // Arrange
            var employee = new Employee("Hanna", "Solska");

            employee.AddScore(3);
            employee.AddScore(0);
            employee.AddScore(1);

            // Act
            var statistics = employee.GetStatistics();
            // Assert
            Assert.AreEqual(1.33333337f, statistics.Average);
            // tutaj mia�em problem jak zapisa� oczekiwan� warto�� 1.(3),
            // ale pom�g� mi nieudany test, kt�ry powiedzia� czego oczekuje,
            // a to zgadza�o si� z moj� intuicj� matematyczn� 1 . 3 na siedmiu miejscach
        }


    }
}