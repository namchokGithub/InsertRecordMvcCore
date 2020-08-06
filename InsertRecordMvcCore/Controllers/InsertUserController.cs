using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsertRecordMvcCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

/*
 * Namespace: InsertRecordMvcCore
 * Class: IncsertUserController
 * Author: Namchok
 */
namespace InsertRecordMvcCore.Controllers
{

    public class InsertUserController : Controller
    {
        private readonly ConnectionStringClass _cc;
        private readonly IConfiguration configuration;

        public InsertUserController(ConnectionStringClass cc, IConfiguration config) {
            this._cc = cc;
            this.configuration = config;
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
        [ValidateAntiForgeryToken] // การป้องกัน Hacker Post ข้อมูลเปลี่ยนแปลงข้อมูล Model 
        public IActionResult Create(AccountClass ac)
        {
            _cc.Add(ac);
            _cc.SaveChanges();
            ViewBag.message = "The record " + ac.Username + " is saved Successfully!";
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        // [ValidateAntiForgeryToken] // การป้องกัน Hacker Post ข้อมูลเปลี่ยนแปลงข้อมูล Model 
        public IActionResult Edit(int id)
        {
            AccountClass ac = _cc.Find<AccountClass>(id);
            return View(ac);
        }

        [HttpPost]
        public IActionResult EditUser(AccountClass ac)
        { 
            if (ModelState.IsValid)
            { 
                _cc.Update(ac);
                _cc.SaveChanges();
            }
            return RedirectToAction("Index", "Management", null);
        }
    }
}
