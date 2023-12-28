namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        void AddScore(float score);
        void AddScore(string score);
        void AddScore(char score);

        Statistics GetStatistics();
    }
}
