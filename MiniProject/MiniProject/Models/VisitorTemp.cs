using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject.Models
{
    public class VisitorTemp
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Key]
        [MaxLength(15)]
        [RegularExpression(@"^\d{10}$")]
        public string Contact { get; set; }
    }
}
