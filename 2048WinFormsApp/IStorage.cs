namespace _2048WinFormsApp
{
    public interface IStorage
    {
        void SaveResultGame(User user);
        List<User> GetUserResults();
        void SaveSettings(List<Settings> settings);
        List<Settings> GetSettings();
    }
}