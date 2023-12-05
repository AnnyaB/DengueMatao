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

        // GET: api/<CasoDengueController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CasoDengueDTO>>> GetCasosDengue()
        {
            var todosCasosDengue = await _casoDengueService.GetCasoDengue();
            if (todosCasosDengue == null)
            {
                return NotFound("Casos de dengue não foram encontrados");
            }
            return Ok(todosCasosDengue);
        }

        // GET api/<CasoDengueController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CasoDengueDTO>> GetId(int id)
        {
            var CasoDengue = await _casoDengueService.GetById(id);
            if (CasoDengue == null)
            {
                return NotFound("Pessoa Afetada não encontrada");
            }
            return Ok(CasoDengue);
        }

        //POST api/<CasoDengueController>
        [HttpPost]
        public async Task<ActionResult<CasoDengueDTO>> PostCasoDengue(CasoDengueDTO casoDengueDTO)
        {         
            if (casoDengueDTO == null)
            {
                return BadRequest("Caso Dengue invalido");
            }
            await _casoDengueService.Add(casoDengueDTO);
            return CreatedAtAction(nameof(GetCasosDengue), new { id = casoDengueDTO.Id }, casoDengueDTO);
        }

        // PUT api/<CasoDengueController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<CasoDengueDTO>> UpdateCasoDengue(CasoDengueDTO casoDengueDTO)
        {
            if (casoDengueDTO == null)
            {
                return BadRequest("Caso Dengue invalido");
            }
            await _casoDengueService.Update(casoDengueDTO);
            return CreatedAtAction(nameof(GetId), new { id = casoDengueDTO.Id }, casoDengueDTO);
        }

        // DELETE api/<PessoaAfetadaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CasoDengueDTO>> DeleteCasoDengue(int id)
        {
            var casoDengueDTO = _casoDengueService.GetById(id);
            if (id == null)
            { 
                return BadRequest("Caso Dengue invalido");
            }
            await _casoDengueService.Delete(id);
            return Ok(casoDengueDTO);
        }
}
}
