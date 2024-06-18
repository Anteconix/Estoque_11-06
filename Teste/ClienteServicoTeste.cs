using Bogus;
using Bogus.Extensions.Brazil;
using Bogus.Extensions.Romania;
using Dominio;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class ClienteServicoTeste
    {
        // atributos
        private ClienteDTO _clienteDTO;
        private Mock<IClienteRepositorio> _clienteRepositorioMock;
        private ClienteServico _clienteServico;


        public ClienteServicoTeste()
        {
            Faker faker = new Faker();

            _clienteDTO = new ClienteDTO 
            { 
                Codigo = faker.Random.Int(1,1000),
                Nome = faker.Person.FullName,
                Endereco = faker.Person.Address.Street,
                Telefone = faker.Person.Phone,
                Cpf = faker.Person.Cpf(),
                Email = faker.Person.Email,
                Rg = faker.Person.Cnp(),
                Apelido = faker.Random.Word()
            };

            _clienteRepositorioMock = new Mock<IClienteRepositorio>();

            _clienteServico = new ClienteServico(_clienteRepositorioMock.Object);
        }


        [Fact]
        public void AdicionarCliente()
        {
            _clienteServico.Armazenar(_clienteDTO);

            /*
            _clienteRepositorioMock.Verify(
                obj => obj.Adicionar(
                        It.IsAny<Cliente>()
                    )
                );
            */

            _clienteRepositorioMock.Verify(
                obj => obj.Adicionar(
                        It.Is<Cliente>( cli =>
                            cli.Codigo == _clienteDTO.Codigo
                            &&
                            cli.Nome == _clienteDTO.Nome
                        )
                    )
                );
        }

    }
}
