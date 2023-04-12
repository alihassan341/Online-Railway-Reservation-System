using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Railway_Reservation.Data;
using Railway_Reservation.Models;

namespace Railway_Reservation.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ApplicationContext _context;
        public CitiesController(ApplicationContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            var ListOfCities = _context.Cities.ToList();
            return View(ListOfCities);
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: Cities/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<City>> Create(City Cities)
        {
            if (ModelState.IsValid == true)
            {
                _context.Cities.Add(Cities);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

       
    }
}
