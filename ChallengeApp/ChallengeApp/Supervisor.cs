//using System.ComponentModel.Design;

//namespace ChallengeApp
//{
//    public class Supervisor : IEmployee
//    {
//        private List<float> scores = new List<float>();

//        public Supervisor(string name, string surname)
//        {
//            this.Name = name;
//            this.Surname = surname;
//        }

//        public string Name { get; private set; }

//        public string Surname { get; private set; }

//        public event EmployeeBase.ScoreAddedDelegate ScoreAdded;

//        public void AddScore(float score)
//        {
//            if (score >= 0 && score <= 100)
//            {
//                this.scores.Add(score);
//            }
//            else
//            {
//                throw new Exception($"Score value: {score} is out of range");
//            }
//        }

//        public void AddScore(double score)
//        {
//            this.AddScore((float)score);
//        }

//        public void AddScore(int score)
//        {
//            this.AddScore((float)score);
//        }

//        public void AddScore(string score)
//        {
//            float modifier = 0;
//            float evaluate;
//            char evalstr;

//            if (score.Length == 2)
//            {
//                if (score[0] == '-' || score[1] == '-')
//                {
//                    modifier = -5;
//                    if (score[0] == '-')
//                    {
//                        evalstr = score[1];
//                    }
//                    else
//                    {
//                        evalstr = score[0];
//                    }
//                }
//                else if (score[0] == '+' || score[1] == '+')
//                {
//                    modifier = 5;
//                    if (score[0] == '+')
//                    {
//                        evalstr = score[1];
//                    }
//                    else
//                    {
//                        evalstr = score[0];
//                    }
//                }
//                else
//                {
//                    throw new Exception($"Wrong score: {score}");
//                }
//            }
//            else if (score.Length == 1)
//            {
//                evalstr = score[0];
//            }
//            else
//            {
//                throw new Exception($"Wrong score: {score}");
//            }

//            switch (evalstr)
//            {
//                case '6':
//                    evaluate = 100;
//                    break;
//                case '5':
//                    evaluate = 80;
//                    break;
//                case '4':
//                    evaluate = 60;
//                    break;
//                case '3':
//                    evaluate = 40;
//                    break;
//                case '2':
//                    evaluate = 20;
//                    break;
//                case '1':
//                    evaluate = 0;
//                    break;
//                default:
//                    throw new Exception($"Wrong score: {score}");
//            }
//            this.AddScore((float)(evaluate + modifier));
//        }



//        public void AddScore(char score)
//        {
//            switch (char.ToUpper(score))
//            {
//                case 'A':
//                    this.AddScore(100);
//                    break;
//                case 'B':
//                    this.AddScore(80);
//                    break;
//                case 'C':
//                    this.AddScore(60);
//                    break;
//                case 'D':
//                    this.AddScore(40);
//                    break;
//                case 'E':
//                    this.AddScore(20);
//                    break;
//                default:
//                    throw new Exception($"Wrong Letter: {score}");
//            }
//        }


//        public Statistics GetStatistics()
//        {
//            Statistics statistics = new Statistics();
//            statistics.Average = 0;
//            statistics.Max = float.MinValue;
//            statistics.Min = float.MaxValue;

//            foreach (var score in this.scores)
//            {
//                statistics.Max = Math.Max(statistics.Max, score);
//                statistics.Min = Math.Min(statistics.Min, score);
//                statistics.Average += score;
//            }
//            statistics.Average /= this.scores.Count;

//            switch (statistics.Average)
//            {
//                case var average when average > 80:
//                    statistics.AverageLetter = 'A';
//                    break;
//                case var average when average > 60:
//                    statistics.AverageLetter = 'B';
//                    break;
//                case var average when average > 40:
//                    statistics.AverageLetter = 'C';
//                    break;
//                case var average when average > 20:
//                    statistics.AverageLetter = 'D';
//                    break;
//                default:
//                    statistics.AverageLetter = 'E';
//                    break;
//            }

//            return statistics;
//        }
//    }
//}
