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
            else
            {
                Console.WriteLine($"String: {score} is not float");
            }
        }
        public void AddScore(double score)
        {
            this.AddScore((float)score);
        }
        public void AddScore(long score)
        {
            this.AddScore((float)score);
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

            return statistics;
        }
    }

}
