﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using tcb.model;

namespace tcb.ViewModels
{
    public class EmployeeCreateViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invaliud email address")]
        [Display(Name = "Office Email")]
        [MaxLength(50, ErrorMessage = "name shd be 50 onlhy")]
        public string Email { get; set; }
        [Required]

        public Dept? Department { get; set; }


        public List<IFormFile> Photos { get; set; }

    }
}
