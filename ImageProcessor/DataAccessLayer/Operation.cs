namespace ImageProcessor.DataAccessLayer
{
    public class Operation : Entity<Guid>
    {
        public string OperationType { get; set; }
        public List<ImageOperation> ImageOperations { get; set; }

        public Operation()
        {
            ImageOperations = new List<ImageOperation>();
        }
    }
}
