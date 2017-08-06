namespace CursoDesignPatterns
{
    using System;
    using Interface;

    public class Conta
    {
        public Conta()
        {
            this.DataAbertura = DateTime.Now;
        }

        public double Saldo {get; set; }
        internal IEstadoDaConta Estado;

        public DateTime DataAbertura { get; private set;}

        public void Deposita(double valor)
            => Estado.Deposita(this, valor);

        public void Saca(double valor)
            => Estado.Saca(this, valor);

    }
}