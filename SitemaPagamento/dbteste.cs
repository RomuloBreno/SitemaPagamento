using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SitemaPagamento.Domain;

namespace SitemaPagamento.Domain
{
    public class Dbteste
    {


        public Tuple<Usuario, Cliente> DadosDataBase()
        {

            Usuario user = new Usuario
            {
                IdUser = Guid.NewGuid(),
                Name = "Romulo",
                Email = "teste@teste.com",
                CPF = "123.456.789.10",
                Phone = "11980581033",
                Job = "trainee",
            };

            Cliente cliente = new Cliente
            {
                IdCliente = Guid.NewGuid(),
                Name = "Marcos",
                Email = "Teste@teste.com",
                CPF = "223.456.789.10",
                Phone = "21980581033",
            };



            return new Tuple<Usuario, Cliente>(user, cliente);

            






        }


    }
}
