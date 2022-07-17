using P127_Pronia.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace P127_Pronia.Models
{
    public class Plant:BaseEntity
    {
        public string Name { get; set; }
        //[Column(TypeName ="decimal(6,2)")]
        public decimal Price { get; set; }
        public string Desc { get; set; }
        public string SKU { get; set; }
        public int PlantInformationId { get; set; }
        public PlantInformation PlantInformation { get; set; }
        public List<PlantImage> PlantImages { get; set; }
        public List<PlantCategory> PlantCategories { get; set; }
    }
}
