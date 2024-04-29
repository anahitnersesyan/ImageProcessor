using ImageProcessor.Models;

namespace ImageProcessor.BusinessLayer.Interfaces
{
    public interface IImageManager
    {
        Task<bool> BrowsImageAsync(BrowsImageRequestModel Image);
        Task<bool> AddPluginsToImageAsync(AddPluginsToImageRequestModel requestModel);
        Task<bool> RemovePluginsFromImageAsync(RemovePluginsFromImageRequestModel requestModel);

    }
}
