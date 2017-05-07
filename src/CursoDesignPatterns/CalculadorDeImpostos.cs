namespace CursoDesignPatterns
{
    using System;
    /// <summary>
    /// Class that keep all business about Tax Calculator.
    /// </summary>
    public class CalculadorDeImpostos
    {
        /// <summary>
        /// Method that perform calculation ICMS.
        /// </summary>
        /// <param name="orcamento">Budget</param>
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double icms = imposto.Calcula(orcamento);
            Console.WriteLine(icms);
        }
    }
}