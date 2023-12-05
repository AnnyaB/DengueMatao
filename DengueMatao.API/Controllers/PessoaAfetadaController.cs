using DengueMatao.Application.DTOs;
using DengueMatao.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DengueMatao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaAfetadaController : ControllerBase
    {
        private readonly IPessoaAfetadaService _pessoaAfetadaService;

        public PessoaAfetadaController(IPessoaAfetadaService pessoaAfetadaService)
        {
            _pessoaAfetadaService = pessoaAfetadaService;
        }


        // GET: api/<PessoaAfetadaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PessoaAfetadaDTO>>> Get()
        {
            var todasPessoasAfetadas = await _pessoaAfetadaService.GetPessoaAfetada();
            if (todasPessoasAfetadas == null)
            {
                return NotFound("Pessoas Afetadas não encontradas");
            }
            return Ok(todasPessoasAfetadas);

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
