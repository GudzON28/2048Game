namespace _2048WinFormsApp
{
    internal class Game
    {
        private static IStorage storage = new JsonStorage();

        public static void SaveResultTesting(User user)
        {
            storage.SaveResultGame(user);
        }

        public static List<User> GetUserResults()
        {
            return storage.GetUserResults();
        }

        public static void SaveSettings(List<Settings> settings)
        {
            storage.SaveSettings(settings);
        }

        public static List<Settings> GetSettings()
        {
            return storage.GetSettings();
        }

        public static List<User> SortingUsers(List<User> readedData)
        {
            return readedData.OrderByDescending(s => s.Score).ToList();
        }

        public static void RemoveLables(Label[,] oldLables)
        {
            int rows = oldLables.GetUpperBound(0) + 1;
            int columns = oldLables.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    oldLables[i, j].Dispose();
                }
            }
        }
    }
}
