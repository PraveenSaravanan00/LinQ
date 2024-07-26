using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_M.Models
{
    public class PersonModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int personId { get; set; }
        public required string personName { get; set; }
        public int age { get; set; }
        public DateTime CreatedTime {  get; set; }
    }
}
