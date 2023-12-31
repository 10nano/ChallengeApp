﻿namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void ScoreAddedDelegate(object sender, EventArgs args);
        public event ScoreAddedDelegate ScoreAdded;

        public void SnapEventScoreAdded()
        {
            if (ScoreAdded != null)
            {
                ScoreAdded(this, new EventArgs());
            }
        }

        public EmployeeBase(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public abstract void AddScore(float score);

        public void AddScore(double score)
        {
            this.AddScore((float)score);
        }

        public void AddScore(int score)
        {
            this.AddScore((float)score);
        }

        public void AddScore(string score)
        {
            if (float.TryParse(score, out float result))
            {
                AddScore(result);
            }
            else if (score.Length == 1)
            {
                AddScore(score[0]);
            }
            else
            {
                throw new Exception($"String: {score} is not float");
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
                    throw new Exception($"Wrong Letter: {score}");
            }
        }

        public abstract Statistics GetStatistics();
    }
}
