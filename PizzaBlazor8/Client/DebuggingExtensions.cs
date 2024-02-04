using System.Runtime.InteropServices.ObjectiveC;
using System.Text.Json;

namespace PizzaBlazor8.Client
{
    public class DebuggingExtensions
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        public static string ToJson (Object obj) => JsonSerializer.Serialize(obj, options);
    }
}
