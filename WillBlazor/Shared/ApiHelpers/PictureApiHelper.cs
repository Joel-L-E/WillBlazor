using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WillBlazor.Shared.Entities;
using System.Text.Json;
using Newtonsoft.Json;

namespace WillBlazor.Shared.ApiHelpers
{
    public class PictureApiHelper
    {
        private static string Url = "https://localhost:44389/api/pictures/";

        public static async Task<Picture> GetPictureAsync(int id)
        {
            var client = new HttpClient();
            Url += id.ToString();
            string json = await client.GetStringAsync(Url);
            var picture = JsonConvert.DeserializeObject<Picture>(json); ;
            return picture;
        }

        public static async Task<List<Picture>> GetPicturesAsync()
        {
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(Url);
            var pictures = JsonConvert.DeserializeObject<List<Picture>>(json);
            return pictures;
        }

    }
}
