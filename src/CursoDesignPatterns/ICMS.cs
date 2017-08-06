namespace CursoDesignPatterns
{
    /// <summary>
    /// Class with business of ICMS Tax.
    /// </summary>
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto) { }
        public ICMS() : base() { }

        /// <summary>
        /// Method that calculate ICMS Tax.
        /// </summary>
        /// <param name="orcamento">Budget</param>
        /// <returns>Value with tax applied</returns>
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}