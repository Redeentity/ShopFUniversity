using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Enter your name")]
        [StringLength(15)]
        [Required(ErrorMessage = "Your name is too short")]
        public string name { get; set; }
        [Display(Name = "Enter your surname")]
        [StringLength(25)]
        [Required(ErrorMessage = "Your surname is too short")]
        public string surname { get; set; }
        [Display(Name = "Enter your phone number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(17)]
        [Required(ErrorMessage = "Phone number is incorrect")]
        public string phone { get; set; }
        [Display(Name = "Enter your email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(40)]
        [Required(ErrorMessage = "Your email is too short")]
        public string email { get; set; }
        [Display(Name = "Enter your adress")]
        [StringLength(30)]
        [Required(ErrorMessage = "This adress is incorrect")]
        public string adress { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
