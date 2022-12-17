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

        /// <summary>
        /// Главная страница со списком пользователей
        /// </summary>
        /// <returns>Список пользователей</returns>
        public async Task<IActionResult> Index()
        {
            return View(await db.Clients.ToListAsync());
        }

    }
}