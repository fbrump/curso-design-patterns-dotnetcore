namespace CursoDesignPatterns
{
    using System;
    using CursoDesignPatterns.Builder;
    using CursoDesignPatterns.Observer;
    using CursoDesignPatterns.Venda;

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

            /* NOTE: Decorate
            Imposto impostoComplexo = new ISS(new ICMS());

            Orcamento orcamento = new Orcamento(500.0);

            double valor = impostoComplexo.Calcula(orcamento);

            Console.WriteLine(valor);
            */

            /* NOTE:
            Orcamento reforma = new Orcamento(500.0);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor); // imprime 475,00 pois descontou 5%
            reforma.Aprova(); // aprova nota!
            reforma.Aprova(); // gera erro!

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor); // imprime 465,50 pois descontou 2%

            reforma.Finaliza();
            */

            // CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal();
            // criador.ParaEmpresa("Caelum");
            // criador.ComCnpj("123.456.789/0001-10");
            // criador.ComItem(new ItemDaNota("item 1", 100.0));
            // criador.ComItem(new ItemDaNota("item 2", 200.0));
            // criador.ComItem(new ItemDaNota("item 3", 300.0));
            
            // CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal();
            // criador.ParaEmpresa("Caelum");
            // criador.ComCnpj("123.456.789/0001-10");
            // criador.ComItem(new ItemDaNota("item 1", 100.0));
            // criador.ComItem(new ItemDaNota("item 2", 200.0));
            // criador.ComItem(new ItemDaNota("item 3", 300.0));
            // criador.ComObservacoes("entregar nf pessoalmente");
            // criador.NaDataAtual();

            // CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal();

            // criador.ParaEmpresa("Caelum");
            // criador.ComCnpj("123.456.789/0001-10");
            // criador.ComItem(new ItemDaNota("item 1", 100.0));
            // criador.ComItem(new ItemDaNota("item 2", 200.0));
            // criador.ComItem(new ItemDaNota("item 3", 300.0));
            // criador.ComObservacoes("entregar nf pessoalmente");
            // criador.NaDataAtual();

            // NotaFiscal nf = criador.Constroi();

            var criador = new CriadorDeNotaFiscal();
            criador.ParaEmpresa("Caelum")
                          .ComCnpj("123.456.789/0001-10")
                          .Com(new ItemDaNota("item 1", 100.0))
                          .Com(new ItemDaNota("item 2", 200.0))
                          .Com(new ItemDaNota("item 3", 300.0))
                          .ComObservacoes("entregar nf pessoalmente");
            
            criador.AdicionarAcao(new EnviadorDeEmail());
            criador.AdicionarAcao(new NotaFiscalDao());
            criador.AdicionarAcao(new EnviadorDeSms());

            NotaFiscal nf = criador.Constroi();
        }
    }
}
