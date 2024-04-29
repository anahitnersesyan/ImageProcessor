namespace ImageProcessor.DataAccessLayer
{
    public class Image : Entity<Guid>
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public List<ImageOperation> ImageOperations { get; set; }

        //We store image file in folder, not in DB
        public Image()
        {
            ImageOperations = new List<ImageOperation>();
        }
    }
}
