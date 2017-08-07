namespace CursoDesignPatterns.Observer
{
    using System;
    using Venda;
    using Interface;

    public class Multiplicador : IAcaoAposGerarNota
    {
        public double Fator {get; private set; }

        public Multiplicador(double fator) => this.Fator = fator;

        public void Executa(NotaFiscal nf) => Console.WriteLine(nf.ValorBruto * this.Fator);
        
    }
}