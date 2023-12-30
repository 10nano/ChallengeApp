using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        void AddScore(float score);
        void AddScore(double score);
        void AddScore(int score);
        void AddScore(string score);
        void AddScore(char score);

        event ScoreAddedDelegate ScoreAdded;

        Statistics GetStatistics();
    }
}
