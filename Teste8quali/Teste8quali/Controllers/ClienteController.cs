using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Teste8quali.Models;
using Teste8quali.Repository;

namespace Teste8quali.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IActionResult Index()
        {
            List<ClienteModel> clientes = _clienteRepository.BuscarTodos();
            return View(clientes);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ClienteModel Cliente, EmailModel email)
        {
            _clienteRepository.Adicionar(Cliente, email);
            return RedirectToAction("Index");
        }

        public IActionResult Apagar(int id)
        {
            ClienteModel cliente = _clienteRepository.ListarPorId(id);
            _clienteRepository.Apagar(cliente);
            return RedirectToAction("Index");
        }
    }
}
