using P127_Pronia.Models.Base;
using System.Collections.Generic;

namespace P127_Pronia.Models
{
    public class PlantCategory:BaseEntity
    {
        public int PlantId { get; set; }
        public Plant Plant { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

     
    }
}
