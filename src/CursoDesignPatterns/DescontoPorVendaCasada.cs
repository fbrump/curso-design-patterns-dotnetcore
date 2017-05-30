namespace CursoDesignPatterns
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            Console.WriteLine("Venda casada");
            if (this.Existe("LAPIS", orcamento) && this.Existe("CANETA", orcamento))
                return orcamento.Valor * 0.05;
            return this.Proximo.Desconta(orcamento);
        }

        private bool Existe(string nomeDoItem, Orcamento orcamento)
        {
            if (orcamento.Itens.Any(t => t.Nome == nomeDoItem))
                return true;
            
            return false;
        }
    }
}