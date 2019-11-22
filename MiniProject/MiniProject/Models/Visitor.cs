using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject.Models
{
    public class Visitor
    {
        public int VisitorNum { get; set; }
        [Required]
        public string VisitorName { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Key]
        [MaxLength(15)]
        [RegularExpression(@"^\d{10}$", ErrorMessage ="Please Enter the Valid Mobile Number")]
        public string Contact { get; set; }
        [Required]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Picture { get; set; }
        [Required]
        public string Ename { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string EmpEmail { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}
