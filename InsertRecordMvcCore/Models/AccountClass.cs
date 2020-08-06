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
        public int acc_Id { get; set; }

        [Required]
        public String acc_Firstname { get; set; }   // ชื่อจริง 

        [Required]
        public String acc_lastname { get; set; }    // นามสกุล

        [Required]
        public String acc_user { get; set; }        // อีเมลหรือเบอร์โทรศัพท์

        [Required]
        public String acc_password { get; set; }    // รหัสผ่าน

        [Required]
        public char acc_IsChangePassword { get; set; }  // ตรวจสอบว่าเปลี่ยนรหัสผ่านหรือยัง

        [Required]
        public char acc_IsActive { get; set; }  // ตรวจสอบสถานะว่าบัญชีนี้ใช้งานได้หรือไม่

        [Required]
        public int acc_ro_Id { get; set; } // Foreign key ของตางราง Role

        [Required]
        public String acc_ta_Id { get; set; } // Foreign key ของตางราง Type_Account
    }
}
