using System.Text.Json.Serialization;

namespace StoryTelling.Models
{
    internal class ApiResponseDTO
    {
        [JsonPropertyName("msg")]
        public string? Msg { get; set; }

        [JsonPropertyName("foodid")]
        public string? FoodId { get; set; }
    }
}
