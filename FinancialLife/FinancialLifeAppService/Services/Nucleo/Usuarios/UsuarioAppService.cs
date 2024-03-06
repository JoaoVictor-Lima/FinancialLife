using FinancialLifeApplication.Interfaces.Nucleo.Usuarios;
using FinancialLifeDomain.Entities.Nucleo.Usuarios;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Usuarios;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Services.Nucleo.Usuarios
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioAppService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<Usuario> CreateAsync(Usuario entity)
        {
            return await _repository.Create(entity);
        }
    }
}
