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
        public BookInfo PublishingHouse { get; set; } = new BookInfo();
    }

    public class BookInfo
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;
    }
}
