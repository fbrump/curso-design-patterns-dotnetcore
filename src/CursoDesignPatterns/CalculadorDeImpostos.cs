namespace CursoDesignPatterns
{
    using System;
    /// <summary>
    /// Class that keep all business about Tax Calculator.
    /// </summary>
    public class CalculadorDeImpostos
    {
        /// <summary>
        /// Method that perform calculation.
        /// </summary>
        /// <param name="orcamento">Budget</param>
        public void RealizaCalculo(Orcamento orcamento, string imposto)
        {
            if ("ICMS".Equals(imposto)){
                double icms = new ICMS().CalculaICMS(orcamento);
                Console.WriteLine(icms);
            }
            else if ("ISS".Equals(imposto)){
                double iss = new ISS().CalculaISS(orcamento);
                Console.WriteLine(iss);
            }
        }
    }
}