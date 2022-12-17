using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NursaceMVC.Models;

namespace NursaceMVC.Controllers
{
    public class ClientController : Controller
    {
        ApplicationContext db;
        public ClientController(ApplicationContext context)
        {
            db = context;
        }

        /// <summary>
        /// Страница с формой добавления клиента
        /// </summary>
        public IActionResult CreateClient()
        {
            return View();
        }

        /// <summary>
        /// POST метод добавления клиента
        /// </summary>
        /// <param name="client">обьект пользователя, который создаем</param>
        [HttpPost]
        public async Task<IActionResult> CreateClient(Client client)
        {
            db.Clients.Add(client);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// Страница с формой редактирования клиента
        /// </summary>
        /// <param name="id">id пользователя который будем редактировать</param>
        public async Task<IActionResult> EditClient(int? id)
        {
            if (id != null)
            {
                Client? client = await db.Clients.FirstOrDefaultAsync(c => c.Id == id);
                if (client != null)
                    return View(client);
            }
            return NotFound();
        }

        /// <summary>
        /// POST метод редактирования клиента
        /// </summary>
        /// <param name="client">обьект пользователя, которого отредактировали</param>
        [HttpPost]
        public async Task<IActionResult> EditClient(Client client)
        {
            db.Clients.Update(client);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// POST метод удаления клиента
        /// </summary>
        /// <param name="id">id пользователя</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> DeleteClient(int? id)
        {
            if (id != null)
            {
                Client client = new Client { Id = id.Value };
                db.Entry(client).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return NotFound();
        }
    }
}
