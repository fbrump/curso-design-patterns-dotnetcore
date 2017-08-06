namespace CursoDesignPatterns.Estados.ContaBancaria
{
    using System;
    using Interface;
    using CursoDesignPatterns;

    public class Positivo : IEstadoDaConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void Saca(Conta conta, double valor)
        {
            conta.Saldo -= valor;

            if(conta.Saldo < 0) conta.Estado = new Negativo();   
        }

    }
}