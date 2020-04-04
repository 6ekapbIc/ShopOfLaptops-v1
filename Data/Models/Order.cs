using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Your name")]
        [StringLength(20)]
        [Required(ErrorMessage = "Not more than 20 symbols")]
        public string name { get; set; }

        [Display(Name = "Your surname")]
        [StringLength(20)]
        [Required(ErrorMessage = "Not more than 20 symbols")]
        public string surName { get; set; }

        [Display(Name = "Your phone")]
        [StringLength(10)]
        [Required(ErrorMessage = "Not more than 10 numbers")]
        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }

        [Display(Name = "Your email address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "@, .com is required!")]
        public string email { get; set; }

        [Display(Name = "Fill the blank")]

        public string address { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get;set; }

        [BindNever]
        public List<OrderDetail> orderDetails { get; set; }
    }
}
