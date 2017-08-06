namespace CursoDesignPatterns
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Estados;
    using Interface;

    /// <summary>
    /// Class controller all budget
    /// </summary>
    public class Orcamento
    {
        /// <summary>
        /// Property that keep budget value
        /// </summary>
        /// <returns>Return budget value </returns>
        public double Valor {get; set; }
        public IList<Item> Itens {get; private set; }

        public IEstadoDeUmOrcamento EstadoAtual { get; set; } // veja a mudança aqui

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="valor">Value that will insert in property <see>Valor</see>.</param>
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra() 
            => EstadoAtual.AplicaDescontoExtra(this);

        public void AdicionaItem(Item item)
        {
            this.Itens.Add(item);
        }

        public void Aprova() 
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova() 
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza() 
        {
            EstadoAtual.Finaliza(this);
        }

    }
}