using ImageProcessor.BusinessLayer.Interfaces;
using ImageProcessor.DataAccessLayer;
using ImageProcessor.DataAccessLayer.Interfaces;
using ImageProcessor.Models;

namespace ImageProcessor.BusinessLayer
{
    public class ImageManager : IImageManager
    {

        private readonly IImageRepository  _imageRepository;
        private readonly IOperationRepository   _operationRepository;
        private readonly IImageOperationRepository   _imageOperationRepository;

        public ImageManager(IImageRepository imageRepository,
                            IOperationRepository operationRepository,
                            IImageOperationRepository imageOperationRepository)
        {
            _imageRepository = imageRepository;
            _operationRepository = operationRepository;
            _imageOperationRepository = imageOperationRepository;
        }
        public async Task<bool> AddPluginsToImageAsync(AddPluginsToImageRequestModel requestModel)
        {
            if(!requestModel.OperationIds.Any())
            {
                return false;
            }
            bool imageExists = await _imageRepository.AnyAsync(x => x.Id== requestModel.ImageId);
            if(!imageExists)
            {
                return false;
            }
            //TODO same way validate operations also

            var pluginsToAdd = requestModel.OperationIds.Select(opId => new ImageOperation
            {
                ImageId = requestModel.ImageId,
                OperationId = opId
            });

            await _imageOperationRepository.AddRangeAsync(pluginsToAdd);
            var addSuccess = await _imageOperationRepository.SaveChangesAsync();
            if(!addSuccess)
            {
                return false;
            }
            return true;
        }


        public async Task<bool> RemovePluginsFromImageAsync(RemovePluginsFromImageRequestModel requestModel)
        {
            if (!requestModel.OperationIds.Any())
            {
                return false;
            }
            //TODO Validate if Image_Operations exists.
            var imagePluginsToRemove = await _imageOperationRepository.GetAsync(x => x.ImageId == requestModel.ImageId
                                                                    && requestModel.OperationIds.Contains(x.OperationId));

            if(imagePluginsToRemove.Any())
            {
                _imageOperationRepository.RemoveByRange(imagePluginsToRemove);
                var removeSuccess = await _imageOperationRepository.SaveChangesAsync();
                if(!removeSuccess)
                {
                    return false;
                }
            }

            return true;
        }

        public  Task<bool> BrowsImageAsync(BrowsImageRequestModel Image)
        {
            throw new NotImplementedException();
        }
    }
}
