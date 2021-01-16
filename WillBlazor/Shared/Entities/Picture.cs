using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace WillBlazor.Shared.Entities
{
    public class Picture
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("pictureUrl")]
        public string PictureUrl { get; set; }
        [JsonPropertyName("heightPx")]
        public int HeightPx { get; set; }
        [JsonPropertyName("widthPx")]
        public int WidthPx { get; set; }
        [JsonPropertyName("photoCredit")]
        public string PhotoCredit { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
         
    }
}
