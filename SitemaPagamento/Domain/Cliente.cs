﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitemaPagamento.Domain
{
    public class Cliente : Pessoa
    {
        public Guid IdCliente { get; set; }
        public string CNPJ { get; set; }
        public string Beens { get; set; }

    }
}
