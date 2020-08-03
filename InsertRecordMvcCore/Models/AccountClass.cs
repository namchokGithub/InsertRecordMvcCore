using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InsertRecordMvcCore.Models
{
    public class AccountClass
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public String Username { get; set; }

        [Required]
        public String Password { get; set; }
    }
}
