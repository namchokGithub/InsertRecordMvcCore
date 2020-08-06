using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/*
 * Namespace: InsertRecordMvcCore
 * Name class: RoleClass
 * Author: Namchok
 */

namespace InsertRecordMvcCore.Models
{

    public class RoleClass
    {
        [Key]
        public int ro_Id { get; set; }
        [Required]
        public string ro_Name { get; set; }
    }
}
