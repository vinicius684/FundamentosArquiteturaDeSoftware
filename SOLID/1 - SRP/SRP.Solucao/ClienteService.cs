namespace SOLID.SRP.Solucao
{
    public class ClienteService
    {
        //tudo bem acumular ter várias responsabilidades, pois todas se encaixam em 1 mesmo motivo, ser um serviço de Cliente
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailServices.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}