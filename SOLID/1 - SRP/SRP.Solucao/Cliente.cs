using System;

namespace SOLID.SRP.Solucao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Cpf Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar() //Tudo bem a classe de deffinição se autovalidar
        {
            return Email.Validar() && Cpf.Validar();
        }
    }
}