using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniProject.Data;
using MiniProject.Models;

namespace MiniProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        ApplicationDbContext context;
        public HomeController()
        {
            context = new ApplicationDbContext();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Visitor v,IFormCollection form)
        {
            if(ModelState.IsValid)
            {
                string storePath = "wwwroot/images/JCI/";
                string dbPath = "/images/JCI/";
                if (form.Files == null || form.Files[0].Length == 0)
                    return RedirectToAction("Index");


                var path = Path.Combine(
                            Directory.GetCurrentDirectory(), storePath,
                            form.Files[0].FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await form.Files[0].CopyToAsync(stream);
                }

                StoreInDB(dbPath + form.Files[0].FileName, v);
                context.Visitors.Add(v);
                context.SaveChanges();
                return View("Thanks");
            }
            return View(v);
        }
        public void StoreInDB(string path, Visitor v)
        {
            v.Picture = path;
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
