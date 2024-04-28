using FinacialLifeDtos.Nucleo.Localizacao;

namespace FinacialLifeDtos.Nucleo.Pessoas
{
    public class EnderecoPessoaDto
    {
        public int Numero { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public virtual CidadeDto Cidade { get; set; }
        public int IdCidade { get; set; }
        public virtual EstadoDto Estado { get; set; }
        public int IdEstado { get; set; }
        public virtual PaisDto Pais { get; set; }
        public int IdPais { get; set; }
    }
}
