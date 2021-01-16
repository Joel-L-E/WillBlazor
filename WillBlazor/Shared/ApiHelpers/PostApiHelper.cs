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
    public class PostApiHelper
    {
        private static string Url = "https://localhost:44389/api/posts/";

        public static async Task<Post> GetPostAsync(int id)
        {
            var client = new HttpClient();
            Url += id.ToString();
            string json = await client.GetStringAsync(Url);
            var post = JsonSerializer.Deserialize<Post>(json); ;
            return post;
        }

        public static Post GetPost(int id)
        {
            var client = new HttpClient();
            string Url2 = Url + id.ToString();
            var task = client.GetStringAsync(Url);
            task.Wait();
            Post post = new Post();
            post = JsonSerializer.Deserialize<Post>(task.Result);
            return post;
        }

    }
}
