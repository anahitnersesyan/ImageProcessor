namespace ImageProcessor.Models
{
    public class AddPluginsToImageRequestModel
    {
        public Guid ImageId { get; set; }
        public List<Guid> OperationIds { get; set; }
    }
}
