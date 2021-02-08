using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mvccccccccccccccccc.Models
{
    public class student
    {


        [Required]
        [Key]
        public int studentID { get; set; }
        [Column(TypeName = "Varchar(100)")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required]
        [Column(TypeName = "Varchar(100)")]
        [Display(Name = "CIN")]
        public string CIN { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        [Display(Name = "Address")]
        public string Address { get; set; }

    }
}
