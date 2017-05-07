namespace CursoDesignPatterns
{
    /// <summary>
    /// Class with business ISS Tax.
    /// </summary>
    public class ISS : Imposto
    {
        /// <summary>
        /// Method that calculate ISS Tax.
        /// </summary>
        /// <param name="orcamento">Budget</param>
        /// <returns>Value with tax applied</returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}