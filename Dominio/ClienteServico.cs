using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClienteServico
    {
        private IClienteRepositorio _clienterepositorio;

        public ClienteServico(IClienteRepositorio repositorio) 
        {
            _clienterepositorio = repositorio;
        }

        //lógica para cada operação

        public void Armazenar(ClienteDTO cli)
        {
            if (cli == null) throw new ArgumentException("Nenhum cliente foi recebido para armazenamento");
            Cliente cliente = new Cliente(cli.Codigo, cli.Nome,
                cli.Endereco, cli.Telefone,
                cli.Cpf, cli.Email,
                cli.Rg, cli.Apelido);

            _clienterepositorio.Adicionar (cliente);
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
