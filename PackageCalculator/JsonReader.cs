using Newtonsoft.Json;

namespace PackageCalculator
{
    class JsonReader
    {
        public void Run()
        {
            // Reads the data from a specific JSON file
            string filePath = "items.json";
            string jsonText = File.ReadAllText(filePath);

            // converting the JSON into a readable object
            var items = JsonConvert.DeserializeObject<Item[]>(jsonText);
        }
    }
}
