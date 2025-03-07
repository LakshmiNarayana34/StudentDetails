﻿using System.ComponentModel.DataAnnotations;

namespace StudentDb.Model
{
    public class ContactDetails
    {
        [Key]
        public int ContactDetailsId { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
