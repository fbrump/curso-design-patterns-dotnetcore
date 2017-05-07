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
        public void RealizaCalculoICMS(Orcamento orcamento)
        {
            double icms = new ICMS().CalculaICMS(orcamento);
            Console.WriteLine(icms);
        }

        /// <summary>
        /// Method that perform calculation ISS.
        /// </summary>
        /// <param name="orcamento">Budget</param>
        public void RealizaCalculoISS(Orcamento orcamento)
        {
            double iss = new ISS().CalculaISS(orcamento);
            Console.WriteLine(iss);
        }
    }
}