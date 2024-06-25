using System.ComponentModel;

namespace ContractEntity.Enums.Core.People.NatualPerson
{
    public enum PersonGenderEnum : int
    {
        [Description("Masculino")]
        Masculino = -1,

        [Description("Feiminino")]
        Feiminino = -2,

        [Description("Não Informado")]
        NaoInformado = -3
    }
}
