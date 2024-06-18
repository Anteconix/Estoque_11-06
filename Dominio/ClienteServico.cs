using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClienteServico
    {
        // atributos
        private IClienteRepositorio _clienteRepositorio;


        public ClienteServico(IClienteRepositorio repositorio) 
        { 
            _clienteRepositorio = repositorio;
        }

        // lógicas para cada uma da operações
        public void Armazenar(ClienteDTO cli)
        {
            if (cli == null) throw 
              new ArgumentException(
              "Nenhum cliente foi recebido para armazenamento");

            Cliente cliente = new Cliente(
                cli.Codigo, cli.Nome, cli.Endereco,
                cli.Telefone, cli.Cpf, cli.Email,
                cli.Rg, cli.Apelido );

            _clienteRepositorio.Adicionar( cliente );
        }

        public void Alterar()
        { }

        public void Excluir()
        { }

        public Cliente ConsultarPorCodigo()
        {
            return null;
        }
    }
}
