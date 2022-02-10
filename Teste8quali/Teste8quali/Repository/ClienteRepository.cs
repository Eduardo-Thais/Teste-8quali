using System.Collections.Generic;
using System.Linq;
using Teste8quali.Data;
using Teste8quali.Models;

namespace Teste8quali.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly BancoContext _bancoContext;
        public ClienteRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ClienteModel Adicionar(ClienteModel cliente)
        {
            //Grava no banco de dados
            _bancoContext.Cliente.Add(cliente);
            _bancoContext.SaveChanges();
            return cliente;
        }

        public ClienteModel Apagar(ClienteModel cliente)
        {
            ClienteModel clienteDB = ListarPorId(cliente.Id);
            if (clienteDB == null) throw new System.Exception("Houve um erro na deleção do cliente");
            _bancoContext.Cliente.Remove(clienteDB);
            _bancoContext.SaveChanges();
            return cliente;
        }


        public List<ClienteModel> BuscarTodos()
        {
            //lista dados do banco
            return _bancoContext.Cliente.ToList();
        }

        public ClienteModel ListarPorId(int id)
        {
            return _bancoContext.Cliente.FirstOrDefault(x => x.Id == id);
        }
    }
}
