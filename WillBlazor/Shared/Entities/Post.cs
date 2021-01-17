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
        public string DatePosted { get; set; }
        [JsonPropertyName("authorName")]
        public string AuthorName { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("content")]
        public string Content { get; set; }
        [JsonPropertyName("typeOfPost")]
        public int TypeOfPost { get; set; } = 1;
        [JsonPropertyName("section")]
        public string Section { get; set; }
        [JsonPropertyName("summary")]
        public string Summary { get; set; }
        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }


        public Post()
        {
            this.DatePosted = DateTime.Today.ToString("MMMM d, yyyy");
        }
    }
}
