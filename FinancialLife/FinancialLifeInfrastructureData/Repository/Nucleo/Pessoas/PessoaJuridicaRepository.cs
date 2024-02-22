﻿using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Interfaces.Repository;
using FinancialLifeDomain.Interfaces.Repository.Pessoas;
using FinancialLifeInfrastructureData.Context;


namespace FinancialLifeInfrastructureData.Repository.Nucleo.Pessoas
{
    public class PessoaJuridicaRepository : RepositoryBase<PessoaJuridica>, IRepositoryBase<PessoaJuridica>, IPessoaJuridicaRepository
    {
        public PessoaJuridicaRepository(PessoaDbContext context) : base(context)
        {

        }
    }
}