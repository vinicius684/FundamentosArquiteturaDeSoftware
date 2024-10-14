using System;

namespace DemoDI.Cases
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
    }

    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
    }

    public class ClienteRepository : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            // Faz algo
        }
    }

    public interface IClienteServices
    {
        void AdicionarCliente(Cliente cliente);
    }

    public class ClienteServices : IClienteServices//contrato com IClienteService, para poder ser injetada na Controller, além de servir como contrato para definir quais operações ou serviços estâo disponíveis para interarir com clientes
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteServices(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _clienteRepository.AdicionarCliente(cliente);
        }
    }
}