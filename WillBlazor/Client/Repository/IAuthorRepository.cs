using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WillBlazor.Shared.Entities;

namespace WillBlazor.Client.Repository
{
    public interface IAuthorRepository
    {
        Task CreateAuthor(Author author);
        Task<Author> GetAuthor(int Id);
        Task<List<Author>> GetAuthors();
        Task UpdateAuthor(Author author);
        Task DeleteAuthor(int id);
    }
}
