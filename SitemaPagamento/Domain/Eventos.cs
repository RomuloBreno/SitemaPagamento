using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitemaPagamento.Domain
{
    public class Eventos
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; } 
        public Guid UserOwner { get; set;}
        public List<Guid> IdClientes { get; set; }
        public int Beens { get; set; }
    }
}
