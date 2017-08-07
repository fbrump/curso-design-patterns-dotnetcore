namespace CursoDesignPatterns.Builder
{
    using System;
    using System.Collections.Generic;
    using Interface;
    using Observer;
    using Venda;

    public class CriadorDeNotaFiscal
    {
        private String RazaoSocial;
        private String Cnpj;
        private double ValorBruto;
        private double Impostos;
        private DateTime Data  { get; set; }
        private String Observacoes { get; set; }
        private IList<ItemDaNota> TodosItens = new List<ItemDaNota>();

        public CriadorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes)
        {
            this.Data = DateTime.Now;
            this.todasAcoesASeremExecutadas = acoes;
        }

        private IList<IAcaoAposGerarNota> todasAcoesASeremExecutadas = new List<IAcaoAposGerarNota>();

        public NotaFiscal Constroi() 
        {
            var nf =  new NotaFiscal(RazaoSocial, Cnpj, Data, ValorBruto, Impostos, TodosItens, Observacoes);

            foreach (var acao in todasAcoesASeremExecutadas)
                acao.Executa(nf);

            return nf;
        }

        public CriadorDeNotaFiscal ParaEmpresa(String razaoSocial) 
        {
            this.RazaoSocial = razaoSocial;

            return this;
        }

        public CriadorDeNotaFiscal ComCnpj(String cnpj) 
        {
            this.Cnpj = cnpj;

            return this;
        }

        public CriadorDeNotaFiscal ComObservacoes(String observacoes) 
        {
            this.Observacoes = observacoes;

            return this;
        }

        public CriadorDeNotaFiscal Com(ItemDaNota item) 
        {
            TodosItens.Add(item);
            ValorBruto += item.Valor;
            Impostos += item.Valor * 0.05;

            return this;
        }

        public CriadorDeNotaFiscal NaData(DateTime data) 
        {
            this.Data = data;

            return this;
        }

    }
}