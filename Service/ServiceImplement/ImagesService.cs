using CatalogWebApi.Data;
using CatalogWebApi.Models;
using CatalogWebApi.Repository;
using Microsoft.AspNetCore.Hosting;

namespace CatalogWebApi.Service.ServiceImplement
{
    public class ImagesService : IImagesService
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IImagesRepository _imagesRepository;

        public ImagesService(IWebHostEnvironment webHostEnvironment, IImagesRepository imagesRepository)
        {
            _environment = webHostEnvironment;
            _imagesRepository = imagesRepository;
           
        }

        public async Task<List<int>> createImages(List<IFormFile> images, string[] formats)
        {
            var imagesList = new List<int>();

            if (images.Count() <= 0)
            {
                throw new ArgumentNullException(nameof(images));
            }

            var contentPath = _environment.ContentRootPath;
            var path = Path.Combine(contentPath, "uploads");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            foreach (var i in images)
            {
                var ext = Path.GetExtension(i.FileName);
                if (!formats.Contains(ext))
                {
                    throw new ArgumentException("One of your images has a invalid extention");
                }

                var fileName = $"{Guid.NewGuid().ToString()}{ext}";
                var fileNameWithPath = Path.Combine(path, fileName);
                using var stream = new FileStream(fileNameWithPath, FileMode.Create);
                await i.CopyToAsync(stream);

                var image = new Image
                {
                    Name = fileName,
                    Url = fileNameWithPath
                };

                await _imagesRepository.SaveFilesAsync(image);

                imagesList.Add(image.Id);    
            }

            return imagesList;

        }
    }
}
