namespace CatalogWebApi.Service
{
    public interface IImagesService
    {
        Task<List<int>> createImages(List<IFormFile> images, string[] formats);
    }
}
