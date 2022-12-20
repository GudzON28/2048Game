using Newtonsoft.Json;

namespace _2048WinFormsApp
{
    public class JsonStorage : IStorage
    {
        string resultsFileName = "resultsGame.json";
        string settingsFileName = "settings.json";

        public void SaveResultGame(User user)
        {
            var allUserResults = GetUserResults();
            allUserResults.Add(user);

            var jsonData = JsonConvert.SerializeObject(allUserResults, Formatting.Indented);
            FileProvider.Put(resultsFileName, jsonData);
        }

        public List<User> GetUserResults()
        {
            if (FileProvider.Exist(resultsFileName))
            {
                var fileData = FileProvider.Get(resultsFileName);
                return JsonConvert.DeserializeObject<List<User>>(fileData);
            }

            return new List<User>();
        }

        public void SaveSettings(List<Settings> settings)
        {
            var jsonData = JsonConvert.SerializeObject(settings, Formatting.Indented);
            FileProvider.Put(settingsFileName, jsonData);
        }

        public List<Settings> GetSettings()
        {
            if (FileProvider.Exist(settingsFileName))
            {
                var fileData = FileProvider.Get(settingsFileName);
                return JsonConvert.DeserializeObject<List<Settings>>(fileData);
            }

            return new List<Settings>();
        }
    }
}