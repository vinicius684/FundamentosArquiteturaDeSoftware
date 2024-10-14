using System;

namespace OOP
{
    public class Pessoa
    {
        //Estado
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; } 

        //Comportamento
        public int CalcularIdade() 
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }
}