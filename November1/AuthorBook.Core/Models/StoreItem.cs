using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorBook.Core.Models
{
    public class StoreItem
    {
        public Book Book { get; set; }
        public int StockCount { get; set; }

    }
}
