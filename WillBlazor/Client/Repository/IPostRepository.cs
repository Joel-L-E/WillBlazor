using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WillBlazor.Shared.Entities;

namespace WillBlazor.Client.Repository
{
    public interface IPostRepository
    {
        Task CreatePost(Post post);
        Task DeletePost(int Id);
        Task<Post> GetPost(int Id);
        Task<List<Post>> GetPosts();
        Task UpdatePost(Post post);
    }
}
