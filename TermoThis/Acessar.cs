﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Acessar
    {
        private string senha = "abc123";

        public bool Login(string senha)
        {
            return senha == this.senha;
        }
    }
}
