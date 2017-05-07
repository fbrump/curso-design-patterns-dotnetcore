namespace CursoDesignPatterns
{
    /// <summary>
    /// Interface with necessary methods for Tax
    /// </summary>
    public interface Imposto
    {
        /// <summary>
        /// Method that calculate Tax.
        /// </summary>
        /// <param name="orcamento">Budget</param>
        /// <returns>Value with tax applied</returns>
         double Calcula(Orcamento orcamento);
    }
}