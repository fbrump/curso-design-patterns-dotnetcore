namespace CursoDesignPatterns.aplicacaoBancaria
{
    public class ContaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }
        
        public ContaBancaria(string titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }

    }
}