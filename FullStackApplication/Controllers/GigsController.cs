using FullStackApplication.Models;
using FullStackApplication.ViewModel;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;
namespace FullStackApplication.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext _context;
        public GigsController()
        {
            _context = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult Create()
        {


            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }

        [ValidateAntiForgeryToken]
        [Authorize]
        [HttpPost]
        public ActionResult Create(GigFormViewModel viewmodel)
        {
            if (!ModelState.IsValid)
            {
                viewmodel.Genres = _context.Genres.ToList();
                return View("Create", viewmodel);
            }

            var gig = new Gig
            {
                ArtistId = User.Identity.GetUserId(),

                DateTime = viewmodel.getDateTime(),

                GenreId = viewmodel.Genre,
                Venue = viewmodel.Venue
            };
            _context.Gigs.Add(gig);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}