using FinacialLifeDtos.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Interfaces.Utils
{
    public interface IEnumAppService
    {
        public Task<List<EnumValuesDto>> GetValuesEnum(string url);
    }
}
