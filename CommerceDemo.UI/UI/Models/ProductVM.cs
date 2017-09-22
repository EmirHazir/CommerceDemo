using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Concrete;

namespace UI.Models
{
    public class ProductVM
    {
        public List<Product> Products { get; internal set; }


        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int CurrentPage { get; internal set; }
    }
}
