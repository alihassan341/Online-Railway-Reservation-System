using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Railway_Reservation.Data;
using Railway_Reservation.Models;

namespace Railway_Reservation.Controllers
{
    public class UserController : Controller
    {

        private readonly ApplicationContext _context;

        public UserController(ApplicationContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<User>> Register(User Users)
        {
            if (ModelState.IsValid == true)
            {
                _context.Users.Add(Users);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Login));
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<User>> Login(User Users)
        {
            var Record = await _context.Users.Where(o => o.Email == Users.Email && o.Password == Users.Password).FirstOrDefaultAsync();

            if (Record != null)
            {
                TempData["UserName"] = Record != null ? Record.FirstName + Record.LastName : string.Empty;
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController));
            }

            return View();
        }
        public IActionResult LoginPartial()
        {
            return PartialView("_LoginPartial");
        }


    }
}
