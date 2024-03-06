using FinancialLifeDomain.Entities.Nucleo.Usuarios;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Interfaces.Nucleo.Usuarios
{
    public interface IUsuarioAppService
    {
        Task<Usuario> CreateAsync(Usuario entity);
    }
}
