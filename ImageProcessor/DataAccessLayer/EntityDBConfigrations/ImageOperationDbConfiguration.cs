using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImageProcessor.DataAccessLayer.EntityDBConfigrations
{
    public class ImageOperationDbConfiguration : IEntityTypeConfiguration<ImageOperation>
    {
        public void Configure(EntityTypeBuilder<ImageOperation> builder)
        {
            builder.HasOne(x => x.Image)
         .WithMany(o => o.ImageOperations)
         .HasForeignKey(fk => fk.ImageId)
         .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Operation)
        .WithMany(o => o.ImageOperations)
        .HasForeignKey(fk => fk.OperationId)
        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
