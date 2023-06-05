using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarketApp.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatDateTime { get; set; } = DateTime.Now;
    }
}
