using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorBook.Core.Models
{
    public class Basket
    {
        public List<BasketItem>  Items { get; set; }
        public int TotalCount { get; set; }
        public string DiscountCode { get; set; }
    }
}
