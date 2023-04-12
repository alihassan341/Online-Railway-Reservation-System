using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Railway_Reservation.Data;
using Railway_Reservation.Models;

namespace Railway_Reservation.Controllers
{
    public class FareController : Controller
    {
        private readonly ApplicationContext _Context;
        public FareController(ApplicationContext Context)
        {
            _Context = Context;
        }
        public ActionResult Index()
        {
            var ListOfFare = _Context.Fares.ToList();
            return View(ListOfFare);
        }

        // GET: FareController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FareController/Create
        public ActionResult Create()
        {
            //var ListOfTrainName = _Context.Trains.Select(p=>p.Name).ToList();
            ViewBag.TrainName = _Context.Trains.ToList();           
            return View();
        }

        // POST: FareController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult<Fare>> Create(Fare Fares)
        {
            if (ModelState.IsValid == true)
            {
                _Context.Fares.Add(Fares);
                await _Context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}
