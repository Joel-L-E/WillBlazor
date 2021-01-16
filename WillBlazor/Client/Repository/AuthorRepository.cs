using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WillBlazor.Client.Helpers;
using WillBlazor.Shared.Entities;

namespace WillBlazor.Client.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IHttpService httpService;
        private readonly string Url = "api/authors";

        public AuthorRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Author>> GetAuthors()
        {
            var response = await httpService.Get<List<Author>>(Url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Author> GetAuthor(int Id)
        {
            var response = await httpService.Get<Author>($"{Url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateAuthor(Author author)
        {
            var response = await httpService.Post(Url, author);
            if (!response.Success)
            {
                throw new ApplicationException();
            }
        }

        public async Task UpdateAuthor(Author author)
        {
            var response = await httpService.Put(Url, author);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteAuthor(int Id)
        {
            var response = await httpService.Delete($"{Url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }



    }
}
