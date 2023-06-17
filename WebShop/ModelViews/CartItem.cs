using System;
using WebShop.Models;

namespace WebShop.ModelViews
{
    public class CartItem
    {
        public Product product { get; set; }
        public int amount { get; set; }
        public decimal TotalMoney => amount * product.Price.Value;
    }
}
