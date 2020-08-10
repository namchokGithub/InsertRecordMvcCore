﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions.Common;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using InsertRecordMvcCore.Models;
using Microsoft.EntityFrameworkCore;

namespace InsertRecordMvcCore.Controllers
{
    public class ManagementController : Controller
    {
        private readonly ConnectionStringClass _cc;
        private readonly IConfiguration configuration;

        public ManagementController(ConnectionStringClass cc, IConfiguration config)
        {
            this._cc = cc;
            this.configuration = config;
        }

        public IActionResult Index()
        {
            List<AccountClass> userlist = _cc.Account.ToList<AccountClass>();
            ViewData["user"] = userlist;

            return View();
        }

        // Just change permission for website
        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                Console.WriteLine(id);
                FormattableString sql_query = @$"EXECUTE dbo.ums_SetNonActive {id}";
                Console.WriteLine(sql_query);
                _cc.Account.FromSqlInterpolated($"EXECUTE dbo.ums_SetNonActive {id}");
                _cc.SaveChanges();
                return RedirectToAction("Index", "Home", null);
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction("Index", "Home", null);
            }
        }
    }
}
