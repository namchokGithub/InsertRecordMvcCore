using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/*
 * Namespace: InsertRecordMvcCore
 * Name class: TypeAccountClass
 * Author: Namchok
 */

namespace InsertRecordMvcCore.Models
{
    public class TypeAccountClass
    {
        [Key]
        public int ta_Id { get; set; }
        [Required]
        public string ta_Name { get; set; }
    }
}
