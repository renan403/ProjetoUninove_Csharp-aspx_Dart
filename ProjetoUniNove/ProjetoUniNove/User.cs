﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoUniNove
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Codigo { get; set; }
        public bool Ativo { get; set; }
    }
}