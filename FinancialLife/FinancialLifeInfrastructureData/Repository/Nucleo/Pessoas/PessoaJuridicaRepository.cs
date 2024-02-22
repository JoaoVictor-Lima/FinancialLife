﻿using FinancialLifeDomain.Entities;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Pessoas;
using FinancialLifeInfrastructureData.Context.Nucleo;


namespace FinancialLifeInfrastructureData.Repository.Nucleo.Pessoas
{
    public class PessoaJuridicaRepository : RepositoryBase<PessoaJuridica>, IRepositoryBase<PessoaJuridica>, IPessoaJuridicaRepository
    {
        public PessoaJuridicaRepository(PessoaDbContext context) : base(context)
        {

        }
    }
}
