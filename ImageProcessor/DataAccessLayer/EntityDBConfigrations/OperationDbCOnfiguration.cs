using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor.DataAccessLayer.EntityDBConfigrations
{
    public class OperationDbCOnfiguration : IEntityTypeConfiguration<Operation>
    {
        public void Configure(EntityTypeBuilder<Operation> builder)
        {
           
        }
    }
}
