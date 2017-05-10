namespace CursoDesignPatterns
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Class controller all budget
    /// </summary>
    public class Orcamento
    {
        /// <summary>
        /// Property that keep budget value
        /// </summary>
        /// <returns>Return budget value </returns>
        public double Valor {get; private set; }
        public IList<Item> Itens {get; private set; }

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="valor">Value that will insert in property <see>Valor</see>.</param>
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            this.Itens.Add(item);
        }
    }
}