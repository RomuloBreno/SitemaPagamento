using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitemaPagamento.Domain
{
    public class Usuario : Pessoa
    {
        public Guid IdUser { get; set; }
        public string Job { get; set; }


    }
}
