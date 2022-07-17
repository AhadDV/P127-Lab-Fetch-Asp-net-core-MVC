using P127_Pronia.Models.Base;
using System.Collections.Generic;

namespace P127_Pronia.Models
{
    public class PlantInformation:BaseEntity
    {
        public string Shipping { get; set; }
        public string AboutReturnRequest { get; set; }
        public string Guarentee { get; set; }
        public List<Plant> Plants { get; set; }
    }
}
