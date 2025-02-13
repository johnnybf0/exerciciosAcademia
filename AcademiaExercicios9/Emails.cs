﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaExercicios9
{
    internal class Emails
    {
        private string _email { get; set; }
        private string _dominio { get; set; }

        public Emails(string email, string dominio)
        {
            _email = email;
            _dominio = dominio;
        }

        public string Email { get => _email; set => _email = value; }
        public string Dominio { get => _dominio; set => _dominio = value; }
    }
}
}
