/// 1. Stwórz klasę Employee, w której przechowasz imię, nazwisko, wiek
/// oraz punkty pracownika w postaci liczb całkowitych
/// 
/// name surname age score


namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();
        public Employee(string name, string surname) // Konstruktor
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; } // Property (pole, właściwość)

        public string Surname { get; private set; } // Property

        public int Result // Metoda
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number) // Metoda
        {
            this.score.Add(number);
        }
    }

}
