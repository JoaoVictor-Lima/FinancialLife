using FinacialLifeDtos.Utils;
using FinancialLifeServices.Interfaces.Utils.Enums;
using System.ComponentModel;

namespace FinancialLifeServices.Services.Utils.Enums
{
    public class GetValuesEnum : IGetValuesEnum
    {
        async Task<List<EnumValuesDto>> IGetValuesEnum.GetValuesEnum(string url)
        {
            string urlFormated = FormatUrl(url);
            string assemblyReference = urlFormated.Split('.')[0];
            var enumType = Type.GetType($"{urlFormated}, {assemblyReference}");

            if (enumType == null)
                throw new ArgumentException("The provided type is not an enum.");

            var enumValues = Enum.GetValues(enumType).Cast<Enum>();

            var enumValuesDto = new List<EnumValuesDto>();
            foreach (var enumValue in enumValues)
            {
                var dto = new EnumValuesDto
                {
                    Id = Convert.ToInt32(enumValue),
                    Value = enumValue.ToString(),
                    Description = GetEnumDescription(enumValue)
                };

                enumValuesDto.Add(dto);
            }

            return await Task.FromResult(enumValuesDto);
        }

        private static string GetEnumDescription(Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            var descriptionAttribute = (DescriptionAttribute)fieldInfo
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .FirstOrDefault();

            return descriptionAttribute != null ? descriptionAttribute.Description : string.Empty;
        }

        private string FormatUrl(string url)
        {
            return url.Replace('/', '.');
        }
    }
}
