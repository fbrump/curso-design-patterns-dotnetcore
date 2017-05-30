namespace CursoDesignPatterns.aplicacaoBancaria
{
    using System;
    using CursoDesignPatterns.aplicacaoBancaria.interfaces;
    public class RespostaEmPorcento : Resposta
    {
        public Resposta Proxima { get; set; }

        public void Resposta(Requisicao req, ContaBancaria conta)
        {
            if (req.Formato == Formato.PORCENTO)
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            else
                this.Proxima.Resposta(req, conta);
        }
    }
}