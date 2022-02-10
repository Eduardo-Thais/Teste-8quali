using System.Collections.Generic;
using Teste8quali.Models;

namespace Teste8quali.Repository
{
    public interface IClienteRepository
    {
        ClienteModel ListarPorId(int id);
        List<ClienteModel> BuscarTodos();
        ClienteModel Adicionar(ClienteModel cliente);
        ClienteModel Apagar(ClienteModel cliente);

        ClienteModel Atualizar(ClienteModel cliente);
    }
}
