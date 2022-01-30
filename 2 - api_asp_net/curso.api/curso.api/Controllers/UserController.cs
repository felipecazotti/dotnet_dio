using curso.api.Filters;
using curso.api.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq;

namespace curso.api.Controllers
{

    [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar", Type = typeof(LoginViewModelInput))]
    [SwaggerResponse(statusCode: 400, description: "Campos Obrigatórios", Type = typeof(ValidateFieldViewModelOutput))]
    [SwaggerResponse(statusCode: 500, description: "Erro interno", Type = typeof(GenericErrorViewModel))]
    [Route("api/v1/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [ValidadeModelStateCustom]
        public IActionResult Login(LoginViewModelInput loginViewModelInput)
        {
            /*
            if (!ModelState.IsValid)
            {
                return BadRequest(new ValidateFieldViewModelOutput(ModelState.SelectMany(sm => sm.Value.Errors).Select(s => s.ErrorMessage)));
            }
            */
            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route("register")]
        [ValidadeModelStateCustom]
        public IActionResult Register(RegisterViewModelInput registerViewModelInput)
        {
            return Created("", registerViewModelInput);
        }
    }
}
