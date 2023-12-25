namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenAddAnyEmployeeScores_ThenCorrectMinValue()
        {
            // Arrange
            var employee = new Employee();
            employee.AddScore(0);
            employee.AddScore(100);
            employee.AddScore(80);

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
            var employee = new Employee();
            employee.AddScore(40);
            employee.AddScore(100);
            employee.AddScore(80);

            // Act
            var statistics = employee.GetStatistics();
            // Assert
            Assert.That(statistics.Max, Is.EqualTo(100f));
        }

        [Test]
        public void WhenAddEmployeeScores_ThenCorrectAvgValue()
        {
            // Arrange
            var employee = new Employee();
            employee.AddScore(30);
            employee.AddScore(0);
            employee.AddScore(100);

            // Act
            var statistics = employee.GetStatistics();

            // Assert
            var value = Math.Round(statistics.Average, 2);
            Assert.That(value, Is.EqualTo(43.33d));
        }

        [Test]
        public void WhenAddEmployeeScores_ThenCorrectAvgLetter()
        {
            // Arrange
            var employee = new Employee();
            employee.AddScore(30);
            employee.AddScore(0);
            employee.AddScore(100);

            // Act
            var statistics = employee.GetStatistics();
            // Assert
            Assert.That(statistics.AverageLetter, Is.EqualTo('C'));
        }
    }
}