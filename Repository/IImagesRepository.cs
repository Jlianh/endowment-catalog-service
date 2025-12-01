using CatalogWebApi.Models;

namespace CatalogWebApi.Repository
{
    public interface IImagesRepository
    {
        Task SaveFilesAsync(Image image);
    }
}
