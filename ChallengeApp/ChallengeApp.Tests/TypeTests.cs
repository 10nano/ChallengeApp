namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {
            // Arrange
            var emp1 = GetUser("Adam", "Kowal", 44);
            var emp2 = GetUser("Andrzej", "Rydz", 55);
            // Act

            // Assert

        }
        public Employee GetUser(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
}
