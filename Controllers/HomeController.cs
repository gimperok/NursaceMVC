using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NursaceMVC.Models;
using System.Diagnostics;

namespace NursaceMVC.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Clients.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Client client)
        {
            db.Clients.Add(client);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}