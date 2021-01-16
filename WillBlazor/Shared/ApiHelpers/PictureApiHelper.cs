using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WillBlazor.Shared.Entities;
using System.Text.Json;

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
            var picture = JsonSerializer.Deserialize<Picture>(json); ;
            return picture;
        }
    }
}
