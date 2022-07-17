using P127_Pronia.Models;
using System.Collections.Generic;

namespace P127_Pronia.ViewModels
{
    public class LayoutBasketVM
    {
        public List<BasketItemVM> BasketItemVMs { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
