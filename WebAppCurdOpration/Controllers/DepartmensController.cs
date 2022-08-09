using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppCurdOpration.Data;
using WebAppCurdOpration.Models;

namespace WebAppCurdOpration.Controllers
{
    public class DepartmensController : Controller
    {
        private readonly AppliceionDbContext _context;
        public DepartmensController(AppliceionDbContext context)
        {
            _context = context;
        }
        // GET: DepartmensController
        public ActionResult Index()
        {
            var Result = _context.Departmens.Include(x => x.DepartmentName)
                .OrderBy(x => x.DepartmentName).ToList();
            return View(Result);
        }

        // GET: DepartmensController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DepartmensController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmensController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmensController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DepartmensController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmensController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DepartmensController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
