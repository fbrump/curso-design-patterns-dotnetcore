namespace CursoDesignPatterns
{
    /// <summary>
    /// Class with business ISS Tax.
    /// </summary>
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto) {  }

        /// <summary>
        /// Method that calculate ISS Tax.
        /// </summary>
        /// <param name="orcamento">Budget</param>
        /// <returns>Value with tax applied</returns>
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06+ CalculoDoOutroImposto(orcamento);
        }
        
    }
}