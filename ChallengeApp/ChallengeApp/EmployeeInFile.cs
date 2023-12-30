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
                    SnapEventScoreAdded();
                }
                
            }
            else
            {
                throw new Exception($"Score value: {score} is out of range");
            }
        }

        public override Statistics GetStatistics()
        {
            var scoresFromFile = ReadScoresFromFile();
            var result = CountStatistics(scoresFromFile);
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

            foreach (var score in scores)
            {
                statistics.AddScore(score);
            }

            return statistics;
        }
    }
}
