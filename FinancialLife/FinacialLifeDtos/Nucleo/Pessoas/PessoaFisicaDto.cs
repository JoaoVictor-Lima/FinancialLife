using ContractEntity.Enums.Nucleo.Pessoas.PessoaFisica;
using FinacialLifeDtos.Nucleo.Usuarios;

namespace FinacialLifeDtos.Nucleo.Pessoas
{
    public class PessoaFisicaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public GeneroPessoaEnum IdGeneroPessoa { get; set; }
        public TelefonePessoaDto TelefonePessoa { get; set; }
        public EmailPessoaDto EmailPessoa { get; set; }
        public EnderecoPessoaDto EnderecoPessoa { get; set; }
        public UsuarioDto Usuario { get; set; }
    }
}
