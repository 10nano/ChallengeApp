namespace ChallengeApp
{
    public class Employee
    {
        private List<float> scores = new List<float>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = -1;
        }
        
        public Employee()
        {
            this.Name = "Test";
            this.Surname = "Test";
            this.Age = -1;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public void AddScore(float score)
        {
            if (score >= 0 && score <= 100)
            {
                this.scores.Add(score);
            }
            else
            {
                Console.WriteLine($"Score value: {score} is out of range");
            }
        }

        public void AddScore(string score)
        {
            if (float.TryParse(score, out float result))
            {
                this.AddScore(result);
            }
            else if (score.Length == 1)
            {
                AddScore((char)score[0]);
            }
            else
            {
                Console.WriteLine($"String: {score} is not float");
            }
        }

        public void AddScore(char score)
        {
            switch (char.ToUpper(score))
            {
                case 'A':
                    this.AddScore(100);
                    break;
                case 'B':
                    this.AddScore(80);
                    break;
                case 'C':
                    this.AddScore(60);
                    break;
                case 'D':
                    this.AddScore(40);
                    break;
                case 'E':
                    this.AddScore(20);
                    break;
                default:
                    Console.WriteLine($"Wrong Letter: {score}");
                    break;
            }
        }

        public Statistics GetStatistics()
        {
            Statistics statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var score in this.scores)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }
            statistics.Average /= this.scores.Count;

            switch (statistics.Average)
            {
                case var average when average > 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average > 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average > 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average > 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
