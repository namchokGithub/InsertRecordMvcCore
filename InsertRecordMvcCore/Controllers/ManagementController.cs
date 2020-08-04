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

namespace InsertRecordMvcCore.Controllers
{
    public class ManagementController : Controller
    {

        private readonly IConfiguration configuration;

        public ManagementController(IConfiguration config)
        {
            this.configuration = config;
        }

        public IActionResult Index()
        {
            string connectionstring = configuration.GetConnectionString("DefaultConnect");

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();

            string sql = "Select ID, Username, Password from account";

            SqlCommand cmSelect = new SqlCommand(sql, connection);
            var user = cmSelect.ExecuteReader();

            List<Models.AccountClass> userlist = new List<Models.AccountClass>();

            while (user.Read())
            {

                userlist.Add(
                    new Models.AccountClass()
                    {
                        ID = (int)user["ID"],
                        Username = user["Username"].ToString(),
                        Password = user["Password"].ToString()
                    }
                );

            }

            ViewData["user"] = userlist;

            connection.Close();

            return View();
        }
    }
}
