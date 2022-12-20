namespace _2048WinFormsApp
{
    public class CurrentGameLog
    {
        public string[,] State { get; set; }
        public int Score { get; set; }

        public CurrentGameLog(string[,] state, int score)
        {
            State = state;
            Score = score;  
        }
    }
}
