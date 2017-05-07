namespace CursoDesignPatterns
{
    /// <summary>
    /// Class with business of ICMS Tax.
    /// </summary>
    public class ICMS
    {
        /// <summary>
        /// Method that calculate ICMS Tax.
        /// </summary>
        /// <param name="orcamento">Budget</param>
        /// <returns>Value with tax applied</returns>
        public double CalculaICMS(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}