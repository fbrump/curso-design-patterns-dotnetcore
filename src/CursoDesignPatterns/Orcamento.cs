namespace CursoDesignPatterns
{
    using System;

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

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="valor">Value that will insert in property <see>Valor</see>.</param>
        public Orcamento(double valor)
        {
            this.Valor = valor;
        }
    }
}