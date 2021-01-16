using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WillBlazor.Shared.Entities
{
    public class Post
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("datePosted")]
        public DateTime DatePosted { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("content")]
        public string Content { get; set; } = "Yeehaw mother truckers its time to build a syte!!!!";
        [JsonPropertyName("typeOfPost")]
        public int TypeOfPost { get; set; }
        [JsonPropertyName("section")]
        public string Section { get; set; }
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        public Post()
        {
            this.DatePosted = DateTime.Today;
        }
    }
}
