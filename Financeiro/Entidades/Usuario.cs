﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Financeiro.Models
{
    public class Usuario
    {

        public int Id { get; set; }
        [Required]
        public string  Nome { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }


    }
}