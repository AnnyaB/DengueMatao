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

        // GET api/<PessoaAfetadaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PessoaAfetadaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PessoaAfetadaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PessoaAfetadaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
