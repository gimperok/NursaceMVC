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

        public IActionResult CreateClient()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateClient(Client client)
        {
            db.Clients.Add(client);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EditClient(int? id)
        {
            if(id != null)
            {
                Client? client = await db.Clients.FirstOrDefaultAsync(c => c.Id == id);
                if (client != null)
                    return View(client);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditClient(Client client)
        {
            db.Clients.Update(client);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteClient(int? id)
        {
            if (id != null)
            {
                Client client = new Client { Id = id.Value };
                db.Entry(client).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}