using FullStackApplication.Models;
using FullStackApplication.ViewModel;
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
        //
        // GET: /Gigs/
        public ActionResult Create()
        {


            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}