using System.IO;
using System.Text.Json;
using static System.Console;

namespace JSON
{
    public class JsonDocumentSample
    {
        public void Run()
        {
            // using stream in this example
            using var stream = File.OpenRead("sample.json");
            using var doc = JsonDocument.Parse(stream);

            var root = doc.RootElement;

            WriteLine("********************************************************************************");
            WriteLine(root.GetProperty("webpage").GetProperty("metadata").GetProperty("seo_title").GetString());
            WriteLine("********************************************************************************");
            EnumerateJsonElement(root);
        }

        private void EnumerateJsonElement(JsonElement root)
        {
            foreach(var prop in root.EnumerateObject())
            {
                if (prop.Value.ValueKind == JsonValueKind.Object)
                {
                    WriteLine($"{prop.Name}");
                    WriteLine("-- BEGIN OBJECT --");
                    EnumerateJsonElement(prop.Value);
                    WriteLine("-- END OBJECT --");
                }
                else if (prop.Value.ValueKind == JsonValueKind.Array)
                {
                    WriteLine($"{prop.Name}");
                    WriteLine("-- BEGIN ARRAY --");
                    foreach(var item in prop.Value.EnumerateArray())
                    {
                        EnumerateJsonElement(item);
                    }
                    WriteLine("-- END ARRAY --");
                }
                else
                    WriteLine($"{prop.Name}: {prop.Value}");
            }
        }
    }
}