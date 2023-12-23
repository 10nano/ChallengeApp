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
            statistics.Min = 99; // Mo�na "zepsu�" test, bo wszystkie propercje w klasie
            // Statistics maj� publiczny set. Jest tak, bo zmienne Min, Max, Average
            // s� ustawiane w klasie Employee.
            // Na razie nie wiem jak to mo�na naprawi� - nie zagl�da�em jeszcze do lekcji
            // dnia 10

            // Assert
            Assert.That(statistics.Min,Is.EqualTo(0f)); // Poprawione po Warning NUnit2005 
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
            Assert.That(statistics.Max, Is.EqualTo(3f));
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
            Assert.That(statistics.Average, Is.EqualTo(1.33333337f));
            // tutaj mia�em problem jak zapisa� oczekiwan� warto�� 1.(3),
            // ale pom�g� mi nieudany test, kt�ry powiedzia� czego oczekuje,
            // a to zgadza�o si� z moj� intuicj� matematyczn� 1 . 3 na siedmiu miejscach
        }


    }
}