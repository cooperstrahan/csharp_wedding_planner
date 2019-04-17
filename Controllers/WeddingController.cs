using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class WeddingController : Controller
    {
        private UserContext dbContext;
        public WeddingController(UserContext context)
        {
            dbContext = context;
        }

        [Route("Dashboard")]
        [HttpGet]
        public IActionResult Index()
        {
            if(isLoggedIn() == false)
            {
                return RedirectToAction("Index", "Login");
            }
            List<Wedding> AllWeddings = WeddingList();
            return View(AllWeddings);
        }

        [HttpGet("new")]
        public IActionResult WeddingForm()
        {
            if(isLoggedIn() == false)
            {
                return RedirectToAction("Index", "Login");
            }
            System.Console.WriteLine(LoggedIn.GetUserID(HttpContext));
            return View();
        }
        
        [HttpPost("new")]
        public IActionResult CreateWedding(AddWedding TheWedding)
        {
            if(ModelState.IsValid)
            {
                Wedding Wedding = new Wedding(TheWedding);
                dbContext.Weddings.Add(Wedding);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("WeddingForm");
            }
        }

        [HttpGet("weddings/{id}")]
        public IActionResult ViewWedding(int id)
        {
            Wedding wedding = dbContext.Weddings
                .Where(w => w.WeddingId == id)
                .Include(wed => wed.Attendees)
                .ThenInclude(p => p.User)
                .FirstOrDefault();
            return View(wedding);
        }
        public List<Wedding> WeddingList()
        {
            List<Wedding> AllWeddings = dbContext.Weddings
                .Include(wed => wed.Attendees)
                .ThenInclude(pln => pln.User)
                .ToList();
            return AllWeddings;
        }

        [HttpGet("rsvp/{id}")]
        public IActionResult RSVP(int id)
        {
            int CurUId = LoggedIn.GetUserID(HttpContext);
            Plans NewPlan = new Plans(CurUId, id);
            dbContext.Plans.Add(NewPlan);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("unrsvp/{id}")]
        public IActionResult UNRSVP(int id)
        {
            int CurUId = LoggedIn.GetUserID(HttpContext);
            Plans NewPlan = new Plans(CurUId, id);
            Plans plan = dbContext.Plans
                .FirstOrDefault(p => p.UserId == CurUId && p.WeddingId == id);
            dbContext.Plans.Remove(plan);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("delete/{id}")]
        public IActionResult DeleteWedding(int id)
        {
            int CurUId = LoggedIn.GetUserID(HttpContext);
            Wedding toDelete = dbContext.Weddings
                .FirstOrDefault(w => w.CreatorId == CurUId && w.WeddingId == id);
            dbContext.Weddings.Remove(toDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }

        public bool isLoggedIn()
        {
            if(LoggedIn.GetUserID(HttpContext) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
