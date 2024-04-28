using System.ComponentModel;

namespace ContractEntity.Enums.Nucleo.Pessoas.PessoaFisica
{
    public enum GeneroPessoaEnum
    {
        [Description("Masculino")]
        Masculino = -1,

        [Description("Feiminino")]
        Feiminino = -2,

        [Description("Não Informado")]
        NaoInformado = -3
    }
}
