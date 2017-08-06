namespace CursoDesignPatterns
{
    using System;

    public class Conta
    {
        public Conta()
        {
            this.DataAbertura = DateTime.Now;
        }

        public double Saldo {get; private set; }

        public DateTime DataAbertura { get; private set;}

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

    }
}