using Newtonsoft.Json;

namespace _2048WinFormsApp
{
    public class Settings
    {
        public string Name { get; set; }
        public string Value { get; set; }

        [JsonConstructor]
        public Settings(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
