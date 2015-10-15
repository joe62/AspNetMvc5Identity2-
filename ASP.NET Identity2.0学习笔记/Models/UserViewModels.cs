﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Users.Models
{
    public class CreateModel
    {
        [Required]
        [Display(Name="用户名")]
        public string Name { get; set; }
        [Required]
        [Display(Name="电子邮件")]
        public string Email { get; set; }
        [Required]
        [Display(Name="用户密码")]
        public string Password { get; set; }
    }
}