using System.IO;
using System.Text.Json;
using static System.Console;

namespace JSON
{
    public class Utf8JsonReaderSample
    {
        public void Run()
        {
            var data = File.ReadAllBytes("sample.json");
            var jsonReader = new Utf8JsonReader(data);

            while (jsonReader.Read())
            {
                WriteLine(GetTokenDesc(jsonReader));
            }
        }

        private string GetTokenDesc(Utf8JsonReader jsonReader)
        {
            return
            jsonReader.TokenType switch
            {
                JsonTokenType.StartObject => "START OBJECT",
                JsonTokenType.EndObject => "END OBJECT",
                JsonTokenType.StartArray => "START ARRAY",
                JsonTokenType.EndArray => "END ARRAY",
                JsonTokenType.PropertyName => $"PROPERTY: {jsonReader.GetString()}",
                JsonTokenType.Comment => $"COMMENT: {jsonReader.GetString()}",
                JsonTokenType.String => $"STRING: {jsonReader.GetString()}",
                JsonTokenType.Number => $"NUMBER: {jsonReader.GetInt32()}",
                JsonTokenType.True => $"BOOL: {jsonReader.GetBoolean()}",
                JsonTokenType.False => $"BOOL: {jsonReader.GetBoolean()}",
                JsonTokenType.Null => "NULL",
                _ => $"UNHANDLED TOKEN {jsonReader.TokenType}"
            };
        }
    }
}