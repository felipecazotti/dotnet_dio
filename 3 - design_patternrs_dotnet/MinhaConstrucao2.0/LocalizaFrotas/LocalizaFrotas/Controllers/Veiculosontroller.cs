using Localiza.Frotas.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocalizaFrotas.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class Veiculosontroller : ControllerBase
    {
        private readonly IVeiculoRepository veiculoRepository;
        public Veiculosontroller(IVeiculoRepository veiculoRepository)
        {
            this.veiculoRepository = veiculoRepository;
        }

        [HttpGet]
        public IActionResult Get() => Ok(veiculoRepository.GetAll());

        [HttpGet("{id}")]

        public IActionResult Get(Guid id)
        {
            var veiculo = veiculoRepository.GetById(id);
            if (veiculo == null) return NotFound();
            return Ok(veiculo);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Veiculo veiculo)
        {
            veiculoRepository.Add(veiculo);
            return CreatedAtAction(nameof(Get), new { id = veiculo.Id }, veiculo);
        }

        [HttpPut]
        public IActionResult Put(Guid id, [FromBody] Veiculo veiculo)
        {
            veiculoRepository.Update(veiculo);
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            var veiculo = veiculoRepository.GetById(id);
            if(veiculo == null) return NotFound();
            veiculoRepository.Delete(veiculo);
            return NoContent();
        }


    }

    
}
