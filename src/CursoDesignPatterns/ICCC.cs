namespace CursoDesignPatterns
{
    using System;
    
    /// <summary>
    /// Class with business of Tax
    /// </summary>
    public class ICCC : Imposto
    {
        /// <summary>
        /// Method that calculate ISS Tax.
        /// </summary>
        /// <param name="orcamento">Budget</param>
        /// <returns>Value with tax applied</returns>
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
                return orcamento.Valor * 0.05;
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
                return orcamento.Valor * 0.05;
            else
                return (orcamento.Valor * 0.8) + 30;
        }
    }
}