using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GildedRoseBoutique.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Please Enter your First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter your Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter your Address")]
        [StringLength(255)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter your Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public DateTime OrderPlacedTime { get; set; }

        public Item Items { get; set; }
        public int ItemId { get; set; }

    }
}
