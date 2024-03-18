using WebApi.Models;

namespace WebApi.Service.FuncionarioService
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponse<List<FuncionarioModel>>> GetAllFuncionarios();
        Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel newFuncionario);
        Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id);
        Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel updatedFuncionario);
        Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id);
        Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id);
    }
}
