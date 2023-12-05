using ChallengeApp;

var user1 = new User("Adam", "463634523");
var user2 = new User("Zuzia", "463634523");
var user3 = new User("Damian", "463634523");

user1.AddScore(2);
user1.AddScore(5);
int result = user1.Result;
Console.WriteLine(result);
