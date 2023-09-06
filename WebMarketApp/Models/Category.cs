using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("عنوان دسته")]
        public string Name { get; set; }
        [Required(ErrorMessage = "لطفا ترتیب دسته وارد کنید")]
        [DisplayName("تزتیب دسته")]
        [Range(1,100,ErrorMessage ="مقدار بین 1 تا 100 مجاز می باشد")]
        public int DisplayOrder { get; set; }
        public DateTime CreatDateTime { get; set; } = DateTime.Now;
    }
}
