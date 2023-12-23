namespace ChallengeApp.Tests
{
    public class Tests
    {
 
        [Test]
        public void WhenAddEmployeeScores_ThenCorrectMinimumValue()
        {
            // Arrange
            var employee = new Employee("Jan", "Dêbski");

            employee.AddScore(3);
            employee.AddScore(0);
            employee.AddScore(1);

            // Act
            var statistics = employee.GetStatistics();
            statistics.Min = 99; // Mo¿na "zepsuæ" test, bo wszystkie propercje w klasie
            // Statistics maj¹ publiczny set. Jest tak, bo zmienne Min, Max, Average
            // s¹ ustawiane w klasie Employee.
            // Na razie nie wiem jak to mo¿na naprawiæ - nie zagl¹da³em jeszcze do lekcji
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
            // tutaj mia³em problem jak zapisaæ oczekiwan¹ wartoœæ 1.(3),
            // ale pomóg³ mi nieudany test, który powiedzia³ czego oczekuje,
            // a to zgadza³o siê z moj¹ intuicj¹ matematyczn¹ 1 . 3 na siedmiu miejscach
        }


    }
}