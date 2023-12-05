namespace ChallengeApp
{
    public class User
    {
        public static string GameName = "Diablo";

        private List<int> score = new List<int>();
        public User(string login, string password) // Konstruktor
        {
            this.Login = login;
            this.Password = password;
        }

        public string Login { get; private set; } // Property (pole, właściwość)

        public string Password { get; private set; } // Property

        public int Result // Metoda
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number) // Metoda
        {
            this.score.Add(number);
        }

     /*   public static Metoda(int nr)
        {
            // bez this.
        }
     */
    }

}
