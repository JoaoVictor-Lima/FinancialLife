namespace FinancialLifeDomain.Entities.Nucleo.Usuarios
{
    public class Usuario
    {
        public int Id { get; set; }
        public string EmailLogin { get; set; }
        public string Senha { get; set; }
        public int IdPessoaFisica { get; set; }
    }
}
