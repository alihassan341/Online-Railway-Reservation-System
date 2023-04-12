using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using Railway_Reservation.Data;
using Railway_Reservation.Models;

namespace Railway_Reservation.Controllers
{
    public class TrainController : Controller
    {
        private readonly ApplicationContext _context;
        public TrainController(ApplicationContext context)
        {
            _context = context;
        }
        
        public ActionResult Index()
        {
            var ListOfTrains = _context.Trains.ToList();
            return View(ListOfTrains);
        }       
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<Train>> Create(Train Trains)
        {
            if (ModelState.IsValid == true)
            {
                _context.Trains.Add(Trains);
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
