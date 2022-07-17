using P127_Pronia.Models;
using System.Collections.Generic;

namespace P127_Pronia.ViewModels
{
    public class BasketVM
    {
        public List<BasketCookieItemVM> BasketCookieItemVMs { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
