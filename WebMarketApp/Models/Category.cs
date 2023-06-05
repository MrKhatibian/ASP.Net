using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarketApp.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatDateTime { get; set; } = DateTime.Now;
    }
}
