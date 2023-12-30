namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event ScoreAddedDelegate ScoreAdded;

        public void SnapEventScoreAdded()
        {
            if (ScoreAdded != null)
            {
                ScoreAdded(this, new EventArgs());
            }
        }

        private List<float> scores = new List<float>();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddScore(float score)
        {
            if (score >= 0 && score <= 100)
            {
                scores.Add(score);
                SnapEventScoreAdded();
            }
            else
            {
                throw new Exception($"Score value: {score} is out of range");
            }
        }

        public override Statistics GetStatistics()
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
