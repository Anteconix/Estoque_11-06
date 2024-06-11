using Bogus;
using Bogus.Extensions.Brazil;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class ClienteBuilder
    {
        // campos
        private int codigo = 1;
        private string nome = "Ze Colmeia";
        private string endereco = "Parque Yellowstone";
        private string telefone = "123";
        private string cpf = "123.456.789-00";
        private string email = "zecolmeia@uol.com.br";
        private string rg = "123";
        private string apelido = "Xunda";


        public static ClienteBuilder Novo()
        {
            return new ClienteBuilder();
        }


        public Cliente Criar() 
        {
            return new Cliente(
                codigo, 
                nome, 
                endereco, 
                telefone, 
                cpf,
                email,
                rg,
                apelido);
        }


        public ClienteBuilder GerarDados()
        {
            Faker faker = new Faker();

            codigo = faker.Random.Int(1,1000);
            nome = faker.Person.FullName;
            endereco = faker.Address.FullAddress();
            telefone = faker.Person.Phone;
            cpf = faker.Person.Cpf();
            email = faker.Person.Email;
            rg = faker.Random.Number().ToString();
            apelido = faker.Random.Word();

            return this;
        }


        public ClienteBuilder ComCodigo(int cod)
        {
            this.codigo = cod;
            return this;
        }


        public ClienteBuilder ComNome(string nom)
        {
            this.nome = nom;
            return this;
        }


        public ClienteBuilder ComEndereco(string end)
        {
            this.endereco = end;
            return this;
        }

        public ClienteBuilder ComTelefone(string fon)
        {
            this.telefone = fon;
            return this;
        }

        public ClienteBuilder ComCPF(string cpf)
        {
            this.cpf = cpf;
            return this;
        }

        public ClienteBuilder ComEmail(string eml)
        {
            this.email = eml;
            return this;
        }

        public ClienteBuilder ComRg(string rg)
        {
            this.rg = rg;
            return this;
        }

        public ClienteBuilder ComApelido(string apelido)
        {
            this.apelido = apelido;
            return this;
        }

    }
}
