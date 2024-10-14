namespace OOP
{
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;
        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar();//obrigatório sobrescrita
        public abstract void Desligar();

        public virtual void Testar()//não obrigatório, mas pode ser
        {
            // teste do equipamento
        }
    }
}