using Newtonsoft.Json;

namespace _2048WinFormsApp
{
    public class User
    {
        public string Name { get; set; }
        public int Score { get; set; }

        [JsonConstructor]
        public User(string name) : this(name, 0)
        {
        }

        public User(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}