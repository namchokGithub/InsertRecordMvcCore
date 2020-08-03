using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsertRecordMvcCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsertRecordMvcCore.Controllers
{

    public class InsertUserController : Controller
    {
        private readonly ConnectionStringClass _cc;

        public InsertUserController(ConnectionStringClass cc) {
            _cc = cc;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AccountClass ac)
        {
            _cc.Add(ac);
            _cc.SaveChanges();
            ViewBag.message = "The record " + ac.Username + " is saved Successfully!";
            return View();
        }
    }
}
