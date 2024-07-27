namespace FinancialLifeInfrastructureData.Utils.Enum
{
    public class EnumDbValueClass
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

        public EnumDbValueClass()
        {
            
        }
        public EnumDbValueClass(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public EnumDbValueClass(int id, string description, string code)
        {
            Id = id;
            Description = description;
            Code = code;
        }
    }
}
