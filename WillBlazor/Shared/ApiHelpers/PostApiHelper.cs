using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WillBlazor.Shared.Entities;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace WillBlazor.Shared.ApiHelpers
{
    [AllowAnonymous]
    public class PostApiHelper
    {
        private static readonly string Url = @"https://localhost:44389/api/posts/";

        public static async Task<List<Post>> GetPostsAsync()
        {
            HttpClient client = new HttpClient();
            string data = await client.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(data);
            return posts;
        }

        public static async Task<Post> GetPostAsync(int id)
        {
            var uri = Url;
            uri += id.ToString();
            HttpClient client = new HttpClient();
            string data = await client.GetStringAsync(uri);
            Post post = JsonConvert.DeserializeObject<Post>(data);
            return post;
        }


        public static async Task<List<Post>> GetBengalsPostsAsync()
        {
            HttpClient client = new HttpClient();
            string data = await client.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(data);
            var bengalsPosts = posts.Where(x => x.Section == "bengals").OrderByDescending(x => x.DatePosted).ToList();
            return bengalsPosts;
        }

        public static async Task<List<Post>> GetRedsPostsAsync()
        {
            HttpClient client = new HttpClient();
            string data = await client.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(data);
            var redsPosts = posts.Where(x => x.Section == "reds").OrderByDescending(x => x.DatePosted).ToList();
            return redsPosts;
        }

        public static async Task<List<Post>> GetRaidersPostsAsync()
        {
            HttpClient client = new HttpClient();
            string data = await client.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(data);
            var wsuPosts = posts.Where(x => x.Section == "wsu").OrderByDescending(x => x.DatePosted).ToList();
            return wsuPosts;
        }

        public static async Task<List<Post>> GetCavaliersPostsAsync()
        {
            HttpClient client = new HttpClient();
            string data = await client.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(data);
            var cavsPosts = posts.Where(x => x.Section == "cavaliers").OrderByDescending(x => x.DatePosted).ToList();
            return cavsPosts;
        }

        public static async Task<List<Post>> GetHawkeyesPostsAsync()
        {
            HttpClient client = new HttpClient();
            string data = await client.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(data);
            var cavsPosts = posts.Where(x => x.Section == "hawkeyes").OrderByDescending(x => x.DatePosted).ToList();
            return cavsPosts;
        }

        public static async Task<List<Post>> GetBrownsPostsAsync()
        {
            HttpClient client = new HttpClient();
            string data = await client.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(data);
            var brownsPosts = posts.Where(x => x.Section == "browns").OrderByDescending(x => x.DatePosted).ToList();
            return brownsPosts;
        }
        
        
        public static async Task<List<Post>> GetOhioStatePostsAsync()
        {
            HttpClient client = new HttpClient();
            string data = await client.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(data);
            var brownsPosts = posts.Where(x => x.Section == "ohiostate").OrderByDescending(x => x.DatePosted).ToList();
            return brownsPosts;
        }
    }
}
