using System;
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

            //string connectionstring = configuration.GetConnectionString("DefaultConnect");
            //string sql = "Select acc_Id, acc_user, acc_password, acc_firstname, acc_lastname" +
            //    "from account";

            //SqlConnection connection = new SqlConnection(connectionstring);
            //connection.Open();

            //SqlCommand cmSelect = new SqlCommand(sql, connection);
            //var user = cmSelect.ExecuteReader();

            //List<Models.AccountClass> userlist = new List<Models.AccountClass>();

            //while (user.Read())
            //{

            //    userlist.Add(
            //        new Models.AccountClass()
            //        {
            //            acc_Id = (int)user["acc_Id"],
            //            acc_user = user["acc_user"].ToString(),
            //            acc_firstname = user["acc_firstname"].ToString(),
            //            acc_lastname = user["acc_lastname"].ToString()
            //        }
            //    );

            //}


            //connection.Close();
            ViewData["user"] = userlist;

            return View();
        }
    }
}
