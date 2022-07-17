using P127_Pronia.Models.Base;

namespace P127_Pronia.Models
{
    public class Setting:BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
