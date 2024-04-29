using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImageProcessor.DataAccessLayer
{
    public  class Entity<T> where T : new()
    {
        /// <summary>
        /// Id SQL primary key column
        /// </summary>
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual T Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Deleted { get; set; }
    }
}
