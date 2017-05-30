namespace CursoDesignPatterns.aplicacaoBancaria
{
    using System;
    using CursoDesignPatterns.aplicacaoBancaria.interfaces;

    public class RespostaEmCsv : Resposta
    {
        public Resposta Proxima { get; set; }

        public void Resposta(Requisicao req, ContaBancaria conta)
        {
            if (req.Formato == Formato.CSV)
                Console.WriteLine(conta.Titular + ";" + conta.Saldo + ";");
            else
                this.Proxima.Resposta(req, conta);
        }
    }
}