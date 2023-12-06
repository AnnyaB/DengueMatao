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
        public async Task<ActionResult<IEnumerable<PessoaAfetadaDTO>>> GetPessoasAfetadas()
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
        public async Task<ActionResult<PessoaAfetadaDTO>> GetId(int id)
        {
            var pessoaAfetada = await _pessoaAfetadaService.GetById(id);
            if (pessoaAfetada == null)
            {
                return NotFound("Pessoa Afetada não encontrada");
            }
            return Ok(pessoaAfetada);
        }

        //POST api/<pessoaAfetadaController>
        [HttpPost]
        public async Task<ActionResult<PessoaAfetadaDTO>> PostPessoaAfetada(PessoaAfetadaDTO pessoaAfetadaDTO)
        {
            if (pessoaAfetadaDTO == null)
            {
                return BadRequest("Caso Dengue invalido");
            }
            await _pessoaAfetadaService.Add(pessoaAfetadaDTO);
            return CreatedAtAction(nameof(GetPessoasAfetadas), new { id = pessoaAfetadaDTO.Id }, pessoaAfetadaDTO);
        }

        // PUT api/<pessoaAfetadaController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<PessoaAfetadaDTO>> UpdatePessoaAfetada(PessoaAfetadaDTO pessoaAfetadaDTO)
        {
            if (pessoaAfetadaDTO == null)
            {
                return BadRequest("Caso Dengue invalido");
            }
            await _pessoaAfetadaService.Update(pessoaAfetadaDTO);
            return CreatedAtAction(nameof(GetId), new { id = pessoaAfetadaDTO.Id }, pessoaAfetadaDTO);
        }

        // DELETE api/<PessoaAfetadaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PessoaAfetadaDTO>> DeletePessoaAfetada(int id)
        {
            var pessoaAfetadaDTO = await _pessoaAfetadaService.GetById(id);
            if (id == null)
            {
                return BadRequest("Caso Dengue invalido");
            }
            await _pessoaAfetadaService.Delete(id);
            return CreatedAtAction(nameof(GetId), new { id = pessoaAfetadaDTO.Id }, pessoaAfetadaDTO);
        }
    }
}
