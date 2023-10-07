using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitemaPagamento.Domain
{
    public class Categorias
    {
        public string IdCategory { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public Guid IdOwner { get; set; }
    }
}
