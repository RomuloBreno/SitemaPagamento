using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SitemaPagamento.Domain;

namespace SitemaPagamento.Domain
{
    public class Dbteste:Pessoa
    {


        public Tuple<User, Client, Event> DadosDataBase()
        {

            User userObject = new User(
                idUser: new Guid(),
                job: "Analista",
                name: "Romulo",
                email: "teste@teste.com",
                phone: "11980581033", 
                cpf: "123.456.789.10"
                );

            Client clientObject = new Client(
                idClient: new Guid(),
                beens: "10",
                name: "Romulo",
                email: "teste@teste.com",
                phone: "11980581033",
                cnpj: "456.789.000/0001-13"
                );

            Event eventObject = new Event(
                idEvent: new Guid(),
                name: "teste evento",
                description: "teste evento",
                category: new Category(),
                date: new DateTime(),
                userOwner: new Guid(),
                idClientes: new List<Guid>(4),
                beens: 10
                );




            return new Tuple<User, Client, Event>(userObject, clientObject, eventObject);

            






        }


    }
}
