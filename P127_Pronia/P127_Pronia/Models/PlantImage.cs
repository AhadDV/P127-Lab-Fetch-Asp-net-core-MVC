using P127_Pronia.Models.Base;

namespace P127_Pronia.Models
{
    public class PlantImage:BaseEntity
    {
        public string Name { get; set; }
        public string Alternative { get; set; }
        public bool? IsMain { get; set; }
        public int PlantId { get; set; }
        public Plant Plant { get; set; }
    }
}
