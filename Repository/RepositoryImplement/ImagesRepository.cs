using CatalogWebApi.Data;
using CatalogWebApi.DTO;
using CatalogWebApi.Models;
using Microsoft.AspNetCore.Routing.Constraints;

namespace CatalogWebApi.Repository.RepositoryImplement
{
    public class ImagesRepository : IImagesRepository
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly AppDbContext _appDbContext;
        public ImagesRepository(IWebHostEnvironment webHostEnvironment, Data.AppDbContext appDbContext) 
        {
            _webHostEnvironment = webHostEnvironment;
            _appDbContext = appDbContext;
        }

        public async Task SaveFilesAsync(Image image)
        {
           await _appDbContext.Images.AddAsync(image);

            await _appDbContext.SaveChangesAsync();
        }
    }
}
