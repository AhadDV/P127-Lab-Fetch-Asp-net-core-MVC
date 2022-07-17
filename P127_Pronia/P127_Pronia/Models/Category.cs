using P127_Pronia.Models.Base;
using System.Collections.Generic;

namespace P127_Pronia.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<PlantCategory> PlantCategories { get; set; }
    }
}
