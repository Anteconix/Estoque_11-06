using Bogus;
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

        _clienteDTO = new ClienteDTO
        Faker faker = new Faker()

        Email = faker.Person.Email,
        Rg = faker.Person.Cnp(),
        Apelido = faker.Random.Word()

        _clienteRepositorioMock = new Mock<IClienteRepositorio>();
        _clienteServico = new ClienteServico(_clienterepositorioMock.Object);

        [Fact]
        public void AdicionarCliente()
        {
            _clienteServico.Armazenar(_clienteDTO);

            // Buscando qualquer "Cliente"

            /* _clienteRepositorioMock.Verify(
                 obj => obj.Adicionar(
                         It.IsAny<Cliente>()
                     )
                 );
            */
            
            // Buscando um "Cliente" específico

            _clienteRepositorioMock.Verify(
                 obj => obj.Adicionar(
                     It.IsAny.Adicionar<Cliente>(
                                cli.Codigo == _clienteDTO.Codigo
                                &&
                                cli.Nome == _clienteDTO.Nome
                            )
                         )
                     );
 
        }
    }
}
