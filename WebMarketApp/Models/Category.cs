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
        [Required(ErrorMessage ="لطفا نام دسته وارد کنید")]
        public string Name { get; set; }
        [Required(ErrorMessage = "لطفا ترتیب دسته وارد کنید")]
        public int DisplayOrder { get; set; }
        public DateTime CreatDateTime { get; set; } = DateTime.Now;
    }
}
