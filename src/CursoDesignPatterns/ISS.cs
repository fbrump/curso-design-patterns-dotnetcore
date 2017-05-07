namespace CursoDesignPatterns
{
    /// <summary>
    /// Class with business ISS Tax.
    /// </summary>
    public class ISS
    {
        /// <summary>
        /// Method that calculate ISS Tax.
        /// </summary>
        /// <param name="orcamento">Budget</param>
        /// <returns>Value with tax applied</returns>
        public double CalculaISS(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}