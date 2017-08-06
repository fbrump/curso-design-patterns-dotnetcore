namespace CursoDesignPatterns
{
    /// <summary>
    /// Interface with necessary methods for Tax
    /// </summary>
    public abstract class Imposto
    {
        public Imposto OutroImposto {get; set;}
        public Imposto(Imposto outroImposto) => this.OutroImposto = outroImposto;

        // construtor default
        public Imposto() => this.OutroImposto = null;

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if(OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }

        /// <summary>
        /// Method that calculate Tax.
        /// </summary>
        /// <param name="orcamento">Budget</param>
        /// <returns>Value with tax applied</returns>
        public abstract double Calcula(Orcamento orcamento);

    }
}