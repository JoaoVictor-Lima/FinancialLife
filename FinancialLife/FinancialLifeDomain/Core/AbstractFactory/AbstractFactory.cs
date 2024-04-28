using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialLifeDomain.Core.AbstractFactory
{
    public abstract class AbstractFactory<TEntity, TDto> : IFactory<TEntity, TDto>
        where TEntity : class 
        where TDto : class
    {
        public abstract TEntity Create(TDto dto);
    }
}
