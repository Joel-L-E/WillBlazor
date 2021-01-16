using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WillBlazor.Shared.Entities;

namespace WillBlazor.Client.Repository
{
    public interface IPictureRepository
    {
        Task CreatePicture(Picture picture);
        Task DeletePicture(int Id);
        Task<Picture> GetPicture(int Id);
        Task<List<Picture>> GetPictures();
        Task UpdatePicture(Picture picture);
    }
}
