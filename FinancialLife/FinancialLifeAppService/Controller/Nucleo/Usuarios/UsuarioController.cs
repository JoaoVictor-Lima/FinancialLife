using FinancialLifeApplication.Interfaces.Nucleo.Usuarios;
using FinancialLifeDomain.Entities.Nucleo.Usuarios;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Controller.Nucleo.Usuarios
{
    [Route("Api/v1/[controller]/[action]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioAppService _appService;

        public UsuarioController(IUsuarioAppService appService)
        {
            _appService = appService;
        }

        public async Task<Usuario> CreateAsync(Usuario entity)
        {
            return await _appService.CreateAsync(entity);
        }
    }
}
