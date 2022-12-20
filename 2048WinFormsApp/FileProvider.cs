using System.Text;

namespace _2048WinFormsApp
{
    public class FileProvider
    {
        public static string Get(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public static void Put(string fileName, string text)
        {
            using (var writer = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                writer.WriteLine(text);
            }
        }

        public static bool Exist(string fileName)
        {
            return File.Exists(fileName);
        }
    }
}
