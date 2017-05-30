namespace CursoDesignPatterns.aplicacaoBancaria
{
    using System;
    using CursoDesignPatterns.aplicacaoBancaria.interfaces;

    public class RespostaEmXml : Resposta
    {
        public Resposta Proxima { get; set; }

        public void Resposta(Requisicao req, ContaBancaria conta)
        {
            if (req.Formato == Formato.XML)
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta
                .Saldo + "</saldo></conta>" );
            else
                Proxima.Resposta(req, conta);
        }
    }
}