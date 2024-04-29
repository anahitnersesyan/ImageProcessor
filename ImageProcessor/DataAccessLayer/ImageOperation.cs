using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor.DataAccessLayer
{
    public class ImageOperation : Entity<Guid>
    {
        public Guid ImageId { get; set; }
        public Image Image { get; set; }

        public Guid OperationId { get; set; }
        public Operation Operation { get; set; }
    }
}
