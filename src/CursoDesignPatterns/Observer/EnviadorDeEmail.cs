namespace CursoDesignPatterns.Observer
{
    using System;
    using Interface;
    using Venda;

    public class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Simula - Envia por e-mail");
        }

    }
}