using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        //The remote tag sends the value of username from the client to server to check if unique, this is client side validation using the server
        [Remote("CheckUserName", "Account")]
        [ScaffoldColumn(false)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Your {0} is required.")]
        [StringLength(16, MinimumLength = 3, ErrorMessage = "{0} is too long.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [MaxWords(10)]
        [Display(Name = "Last Name")]
        [StringLength(16, MinimumLength = 3, ErrorMessage = "{0} is too long.")]
        public string LastName { get; set; }
        [Range(18, 120, ErrorMessage = "{0} is too long.")]
        public int Age { get; set; }       
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Email")]
        public string EmailConfirm { get; set; }
        public decimal Price { get; set; }
        [Range(typeof(decimal), "0.00", "99.99")]
        public decimal Total { get; set; }
        //public List<OrderDetail> OrderDetails { get; set; }
    }
}