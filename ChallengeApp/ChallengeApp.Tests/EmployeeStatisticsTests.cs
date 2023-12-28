namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenAddAnyEmployeeScores_ThenCorrectMinValue()
        {
            // Arrange
            var employee = new Supervisor("A","B");
            employee.AddScore("3+");
            employee.AddScore("-4");
            employee.AddScore("1");

            // Act
            var statistics = employee.GetStatistics();
            // statistics.Min = 99;

            // Assert
            Assert.That(statistics.Min, Is.EqualTo(0f));
        }

        [Test]
        public void WhenAddEmployeeScores_ThenCorrectMaxValue()
        {
            // Arrange
            var employee = new Supervisor("A", "B");
            employee.AddScore("5-");
            employee.AddScore("6");
            employee.AddScore("+2");

            // Act
            var statistics = employee.GetStatistics();
            // Assert
            Assert.That(statistics.Max, Is.EqualTo(100f));
        }

        [Test]
        public void WhenAddEmployeeScores_ThenCorrectAvgValue()
        {
            // Arrange
            var employee = new Supervisor("A", "B");
            employee.AddScore("5");
            employee.AddScore("2+");
            employee.AddScore("3-");

            // Act
            var statistics = employee.GetStatistics();

            // Assert
            var value = Math.Round(statistics.Average, 2);
            Assert.That(value, Is.EqualTo(46.67d));
        }

        [Test]
        public void WhenAddEmployeeScores_ThenCorrectAvgLetter()
        {
            // Arrange
            var employee = new Supervisor("A", "B");
            employee.AddScore("5");
            employee.AddScore("2+");
            employee.AddScore("3-");

            // Act
            var statistics = employee.GetStatistics();
            // Assert
            Assert.That(statistics.AverageLetter, Is.EqualTo('C'));
        }
    }
}