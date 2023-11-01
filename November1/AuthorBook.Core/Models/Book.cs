﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorBook.Core.Models
{
    public class Book
    {
        public Author Author { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }

    }
}
