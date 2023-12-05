using DengueMatao.Application.DTOs;
using DengueMatao.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DengueMatao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasoDengueController : ControllerBase
    {
        private readonly ICasoDengueService _casoDengueService;

        public CasoDengueController(ICasoDengueService casoDengueService)
        {
            _casoDengueService = casoDengueService;
        }
        
        // GET: CasoDengue
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CasoDengueDTO>>> Get()
        {
            var todosCasosDengue = await _casoDengueService.GetCasoDengue();
            if (todosCasosDengue == null)
            {
                return NotFound("Casos de dengue não foram encontrados");
            }
            return Ok(todosCasosDengue);
        } 

        // GET: CasoDengue/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CasoDengue/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CasoDengue/Create
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

        // GET: CasoDengue/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CasoDengue/Edit/5
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

        // GET: CasoDengue/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CasoDengue/Delete/5
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
