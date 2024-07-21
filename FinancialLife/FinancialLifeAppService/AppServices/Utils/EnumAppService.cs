using FinacialLifeDtos.Utils;
using FinancialLifeApplication.Interfaces.Utils;
using FinancialLifeServices.Interfaces.Utils.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.AppServices.Utils
{
    public class EnumAppService : IEnumAppService
    {
        private readonly IGetValuesEnum _service;

        public EnumAppService(IGetValuesEnum service)
        {
            _service = service;
        }

        public async Task<List<EnumValuesDto>> GetValuesEnum(string url)
        {
            return await _service.GetValuesEnum(url);
        }
    }
}
