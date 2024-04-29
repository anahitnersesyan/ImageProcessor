namespace ImageProcessor.Models
{
    public class RemovePluginsFromImageRequestModel
    {
        public Guid ImageId { get; set; }
        public List<Guid> OperationIds { get; set; }
    }
}
