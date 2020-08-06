using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * Namespace: InsertRecordMvcCore
 * Name class: ConnectionStringClass
 * Author: Namchok
 */

namespace InsertRecordMvcCore.Models
{
    public class ConnectionStringClass : DbContext
    {
        public ConnectionStringClass(DbContextOptions<ConnectionStringClass> option) : base(option)
        {

        }

        public DbSet<AccountClass> account
        {
            get; set;
        }

        // เพิ่ม Table อื่น ๆ

    }
}
