using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_M.Models.NewFolder
{
    public class PersonM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int personId { get; set; }
        [Required]
        [MaxLength(30)]
        public required string personName { get; set; }
        public int age { get; set; }
        public DateTime CreatedTime { get; internal set; }
    }
}
