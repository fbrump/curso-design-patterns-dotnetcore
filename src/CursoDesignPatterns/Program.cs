namespace CursoDesignPatterns
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            /* NOTE: IMPOSTO
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, iccc);
            */

            /* NOTE: INVESTIMENTO 
            RealizadorDeInvestimentos realizador = new RealizadorDeInvestimentos();
            Conta conta = new Conta();
            Investimento investimento = new Arrojado();
            
            conta.Deposita(500);

            realizador.Realiza(conta, investimento);
            */

            /* NOTE: DESCONTO 

            CalculadorDeDescontos calculadorDesconto = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);

            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));
            orcamento.AdicionaItem(new Item("GELADEIRA", 250));
            orcamento.AdicionaItem(new Item("FOGAO", 250));
            orcamento.AdicionaItem(new Item("MICROONDAS", 250));
            orcamento.AdicionaItem(new Item("XBOX", 250));

            double desconto = calculadorDesconto.Calcula(orcamento);

            Console.WriteLine(desconto);*/

            Imposto impostoComplexo = new ISS(new ICMS());

            Orcamento orcamento = new Orcamento(500.0);

            double valor = impostoComplexo.Calcula(orcamento);

            Console.WriteLine(valor);

        }
    }
}
