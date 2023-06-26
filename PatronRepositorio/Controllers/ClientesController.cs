using Microsoft.AspNetCore.Mvc;
using PatronRepositorio.Entities;
using PatronRepositorio.Repositories;

namespace PatronRepositorio.Controllers
{
    public class ClientesController : Controller
    {
        // Inyeccion de dependencias
        private readonly IClienteRepository _repository;

        public ClientesController(IClienteRepository repository)
        {
            _repository = repository;
        }

        // GET: ClientesController
        public ActionResult Index()
        {
            return View(_repository.GetAll());
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int id)
        {
            return View(_repository.GetById(id));
        }

        // GET: ClientesController/Create
        public ActionResult Create()
        {
            return View(new Cliente());
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente entidad)
        {
            try
            {
                _repository.Add(entidad);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repository.GetById(id));
        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Cliente entidad)
        {
            try
            {
                _repository.Update(id, entidad);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repository.GetById(id));
        }

        // POST: ClientesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _repository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
