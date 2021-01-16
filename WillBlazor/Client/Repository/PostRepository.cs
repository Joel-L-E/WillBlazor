using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WillBlazor.Client.Helpers;
using WillBlazor.Shared.Entities;

namespace WillBlazor.Client.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly IHttpService httpService;
        private readonly string Url = "api/posts";

        public PostRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Post>> GetPosts()
        {
            var response = await httpService.Get<List<Post>>(Url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Post> GetPost(int Id)
        {
            var response = await httpService.Get<Post>($"{Url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreatePost(Post post)
        {
            var response = await httpService.Post(Url, post);
            if (!response.Success)
            {
                throw new ApplicationException();
            }
        }

        public async Task UpdatePost(Post post)
        {
            var response = await httpService.Put(Url, post);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeletePost(int Id)
        {
            var response = await httpService.Delete($"{Url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }



    }
}
