using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/*
 * Namespace: InsertRecordMvcCore
 * Name class: LogClass
 * Author: Namchok
 */

namespace InsertRecordMvcCore.Models
{
    public class LogClass
    {
        [Key]
        public int log_Id { get; set; }
        [Required]
        public string log_date { get; set; }
        [Required]
        public string log_detail { get; set; }
    }
}
