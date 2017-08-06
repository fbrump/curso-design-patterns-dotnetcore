namespace CursoDesignPatterns.Observer
{
    using System;
    using Venda;
    using Interface;

    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Simula - Salva no banco.");
        }
    }
}