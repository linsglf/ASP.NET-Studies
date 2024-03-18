using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Service.FuncionarioService;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioInterface _funcionarioService;
        public FuncionarioController(IFuncionarioInterface funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetAllFuncionarios()
        {
            return Ok(await _funcionarioService.GetAllFuncionarios());
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> CreateFuncionario(FuncionarioModel newFuncionario)
        {
            return Created("Created!", await _funcionarioService.CreateFuncionario(newFuncionario));
        }
    }
}
