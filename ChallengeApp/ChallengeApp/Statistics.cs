namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; set; }

        public float Max { get; set; }

        public float Sum { get; set; }

        public int Count { get; set; }

        public float Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public char AverageLetter
        {
            get
            {
                switch (Average)
                {
                    case var average when average > 80:
                        return 'A';
                    case var average when average > 60:
                        return 'B';
                    case var average when average > 40:
                        return 'C';
                    case var average when average > 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            Count = 0;
            Sum = 0;
            Min = float.MaxValue;
            Max = float.MinValue;
        }

        public void AddScore(float score)
        {
            Count++;
            Sum += score;
            Min = Math.Min(this.Min, score);
            Max = Math.Max(this.Max, score);
        }
    }
}