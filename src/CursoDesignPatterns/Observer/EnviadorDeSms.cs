namespace CursoDesignPatterns.Observer
{
    using System;
    using Venda;
    using Interface;

    public class EnviadorDeSms : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Simula - Envia por SMS.");
        }

    }
}