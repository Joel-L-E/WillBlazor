using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WillBlazor.Client.Helpers;
using WillBlazor.Shared.Entities;

namespace WillBlazor.Client.Repository
{
    public class PictureRepository : IPictureRepository
    {
        private readonly IHttpService httpService;
        private readonly string Url = "api/pictures";

        public PictureRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Picture>> GetPictures()
        {
            var response = await httpService.Get<List<Picture>>(Url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Picture> GetPicture(int Id)
        {
            var response = await httpService.Get<Picture>($"{Url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreatePicture(Picture picture)
        {
            var response = await httpService.Post(Url, picture);
            if (!response.Success)
            {
                throw new ApplicationException();
            }
        }

        public async Task UpdatePicture(Picture picture)
        {
            var response = await httpService.Put(Url, picture);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeletePicture(int Id)
        {
            var response = await httpService.Delete($"{Url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }



    }
}
