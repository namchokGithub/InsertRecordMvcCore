using Bogus.DataSets;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Azure.Management.Sql.Fluent.Models;
using Nest;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/*
 * Namespace: InsertRecordMvcCore
 * Name class: AccountClass
 * Author: Namchok
 */

namespace InsertRecordMvcCore.Models
{
    public class AccountClass
    {
        [Key]
        [Display(Name="ID")]
        public int acc_Id { get; set; }

        [Required]
        [Display(Name="Name")]
        public String acc_firstname { get; set; }   // ชื่อจริง 

        [Required]
        [Display(Name="Lastname")]
        public String acc_lastname { get; set; }    // นามสกุล

        [Required]
        [Display(Name="Username")]
        public String acc_user { get; set; }        // อีเมลหรือเบอร์โทรศัพท์

        [Required]
        [Display(Name="Password")]
        public String acc_password { get; set; }    // รหัสผ่าน

        [Required]
        public char acc_IsChangePassword { get; set; }  // ตรวจสอบว่าเปลี่ยนรหัสผ่านหรือยัง

        [Required]
        public char acc_IsActive { get; set; }  // ตรวจสอบสถานะว่าบัญชีนี้ใช้งานได้หรือไม่

        [Required]
        [Display(Name="Type of user")]
        public int acc_ro_Id { get; set; } // Foreign key ของตางราง Role

        [Required]
        [Display(Name="Type of account")]
        public int acc_ta_Id { get; set; } // Foreign key ของตางราง Type_Account
    }
}
