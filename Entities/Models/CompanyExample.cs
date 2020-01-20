﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    class CompanyExample
    {
        [Column("CompanyId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage="Company name is required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Company address is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum lenght for the Address is 60 characters.")]
        public string Address { get; set; }
        public string Country { get; set; }
        public ICollection<EmployeeExample> Employees { get; set; }
    }
}
