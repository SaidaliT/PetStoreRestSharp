using Newtonsoft.Json;

namespace Said.PetStore.RestApi.Client.Models.PetModel // Ctrl + . => For changing the namespace base on folder structure
{
    public class PetApiModelV2
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("category")]
        public Category? Category { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("photoUrls")]
        public List<string>? PhotoUrls { get; set; }

        [JsonProperty("tags")]
        public List<Tag>? Tags { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }
    }
    public class Category
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }

    public class Tag
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}