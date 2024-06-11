using Bogus;
using Bogus.DataSets;
using Dominio;
using ExpectedObjects;

namespace Teste
{
    public class ClienteTeste
    {

        // 3º criar o método de teste
        [Fact]
        public void CriarObjetoCliente()
        {
            // Arrange com objeto anônimo
            var cli = ClienteBuilder.Novo().GerarDados().Criar();

            var clienteEsperado = new
            {
                Codigo = cli.Codigo,
                Nome = cli.Nome,
                Endereco = cli.Endereco,
                Telefone = cli.Telefone,
                Cpf = cli.Cpf,
                Email = cli.Email,
                Rg = cli.Rg,
                Apelido = cli.Apelido
            };

            // Act

            // Assert com ExpectedObject
            clienteEsperado.ToExpectedObject().ShouldMatch(cli);
        }




        [Theory]
        [InlineData(null)]
        [InlineData(0)]
        [InlineData(-1)]
        public void ClienteCodigoInvalido(int cod)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ClienteBuilder.Novo().GerarDados().ComCodigo(cod).Criar()
            ) ;

        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ClienteNomeInvalido(string nome)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ClienteBuilder.Novo().GerarDados().ComNome(nome).Criar()
            );

        }



        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ClienteEnderecoInvalido(string end)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ClienteBuilder.Novo().GerarDados().ComEndereco(end).Criar()
            );

        }



        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ClienteTelefoneInvalido(string tel)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ClienteBuilder.Novo().GerarDados().ComTelefone(tel).Criar()
            );

        }



        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("111.222.333-44")]
        public void ClienteCpfInvalido(string cpf)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ClienteBuilder.Novo().GerarDados().ComCPF(cpf).Criar()
            );
            
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("ze")]
        [InlineData("ze@")]
        [InlineData("@bol.com.br")]
        public void ClienteEmailInvalido(string email)
        {
            Assert.Throws<ArgumentException>(
                () =>
                
                ClienteBuilder.Novo().GerarDados().ComEmail(email).Criar()
            );

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ClienteRgInvalido(string rg)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ClienteBuilder.Novo().GerarDados().ComRg(rg).Criar()
            );

        }

    }
}