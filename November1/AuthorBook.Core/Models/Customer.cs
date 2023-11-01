using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorBook.Core.Models
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public Basket Basket { get; set; }
    }
}
