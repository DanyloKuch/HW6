using System.Text.Json.Serialization;

namespace HW6
{
    public class Book
    {
        [JsonIgnore]
        public int PublishingHouseId { get; set; }

        [JsonPropertyName("Name")]
        public string? Title { get; set; }

        [JsonPropertyName("PublishingHouse")]
        public BoolInformation PublishingHouse { get; set; }
    }
}
