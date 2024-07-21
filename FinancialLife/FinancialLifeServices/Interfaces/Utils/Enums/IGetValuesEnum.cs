using FinacialLifeDtos.Utils;

namespace FinancialLifeServices.Interfaces.Utils.Enums
{
    public interface IGetValuesEnum
    {
        public Task<List<EnumValuesDto>> GetValuesEnum(string url);
    }
}
