using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestIdentity2.Models
{
    public class Food
    {
        [Key]
        [StringLength(255)]
        [Required]
        [Column(TypeName = "nvarchar")]
        public string Id { get; set; }

        [StringLength(255)]
        [Required]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [StringLength(255)]
        [Required]
        [Column(TypeName = "nvarchar")]
        public string Content { get; set; }
        public int Type {  get; set; }
        public int Status { get; set; }

        [StringLength(255)]
        [Required]
        [Column(TypeName = "nvarchar")]
        public string CreatedBy { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime CreatedTime{ get; set; }
    }
}
