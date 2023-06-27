using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SII_TEST.Models;

namespace SII_TEST.Controllers
{
    public class calculate : Controller
    {
        private readonly int ID;
        private readonly int salary;
        employee empleado;
        public int GetID()
        {
            return ID;
        }

        // GET: calculate
        public ActionResult Index(int ID,int salary)
        {
            empleado.Id = ID;
            empleado.employee_salary = salary *12;
            return View();
        }

        // GET: calculate/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: calculate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: calculate/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(GetID(), Index));
            }
            catch
            {
                return View();
            }
        }

        private string? nameof(int v, Func<int, int, ActionResult> index)
        {
            throw new NotImplementedException();
        }

        // GET: calculate/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: calculate/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(GetID(), Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: calculate/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        public ActionResult Todos(int id)
        {
            return View();
        }

        // POST: calculate/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(GetID(), Index));
            }
            catch
            {
                return View();
            }
        }

        internal Task<employee> Todos(object id)
        {
            throw new NotImplementedException();
        }
    }
}
