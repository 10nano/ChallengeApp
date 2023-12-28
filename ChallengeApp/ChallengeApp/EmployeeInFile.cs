namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public const string fileName = "scores.txt";

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddScore(float score)
        {
            if (score >= 0 && score <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(score);
                }
            }
            else
            {
                throw new Exception($"Score value: {score} is out of range");
            }
        }

        public override Statistics GetStatistics()
        {
            var scoresFromFile = this.ReadScoresFromFile();
            var result = this.CountStatistics(scoresFromFile);
            return result;
        }

        private List<float> ReadScoresFromFile()
        {
            var scores = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        scores.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return scores;
        }
        private Statistics CountStatistics(List<float> scores)
        {
            Statistics statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var score in scores)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }
            statistics.Average /= scores.Count;

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
