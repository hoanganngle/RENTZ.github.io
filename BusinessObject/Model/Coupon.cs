﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessObject.Model
{
    public partial class Coupon
    {
        public Coupon()
        {
            BookRoom = new HashSet<BookRoom>();
        }
        
        public string Id { get; set; }
        [Required(ErrorMessage = "Discount can not be empty")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Wrong format for Discount number")]
        public int? Discount { get; set; }
        [Required(ErrorMessage = "Description can not be empty")]
        public string Description { get; set; }

        public virtual ICollection<BookRoom> BookRoom { get; set; }
    }
}