using FinacialLifeDtos.Nucleo.Pessoas;
using FinancialLifeDomain.Core.AbstractFactory;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;

namespace FinancialLifeDomain.Factories.Nucleo.Pessoas
{
    public class PessoaFisicaFactory : AbstractFactory<PessoaFisica, PessoaFisicaDto>
    {
        private readonly IFactory<TelefonePessoa, TelefonePessoaDto> _telefonePessoaFactory;
        private readonly IFactory<EmailPessoa, EmailPessoaDto> _emailPessoaFactory;
        private readonly IFactory<EnderecoPessoa, EnderecoPessoaDto> _enderecoPessoaFactory;

        public PessoaFisicaFactory(
            IFactory<TelefonePessoa, TelefonePessoaDto> telefonePessoaFactory,
            IFactory<EmailPessoa, EmailPessoaDto> emailPessoaFactory,
            IFactory<EnderecoPessoa, EnderecoPessoaDto> enderecoPessoaFactory
            )
        {
            _telefonePessoaFactory = telefonePessoaFactory;
            _emailPessoaFactory = emailPessoaFactory;
            _enderecoPessoaFactory = enderecoPessoaFactory;
        }

        public override PessoaFisica Create(PessoaFisicaDto dto)
        {
            var entity = new PessoaFisica();
            entity.AddNome(dto.Nome);
            entity.AddCpf(dto.Cpf);
            entity.AddDataNascimento(dto.DataNascimento);
            entity.AddGeneroPessoa(dto.IdGeneroPessoa);

            entity.AddEmailPessoa(_emailPessoaFactory.Create(dto.EmailPessoa));
            entity.AddTelefonePessoa(_telefonePessoaFactory.Create(dto.TelefonePessoa));
            entity.AddEnderecoPessoa(_enderecoPessoaFactory.Create(dto.EnderecoPessoa));

            return entity;
        }
    }
}
