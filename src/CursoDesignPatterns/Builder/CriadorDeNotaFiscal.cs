namespace CursoDesignPatterns.Builder
{
    using System;
    using System.Collections.Generic;
    using CursoDesignPatterns.Observer;
    using CursoDesignPatterns.Venda;

    public class CriadorDeNotaFiscal
    {
        private String RazaoSocial;
        private String Cnpj;
        private double ValorBruto;
        private double Impostos;
        private DateTime Data  { get; set; }
        private String Observacoes { get; set; }
        private IList<ItemDaNota> TodosItens = new List<ItemDaNota>();

        public CriadorDeNotaFiscal()
        {
            this.Data = DateTime.Now;
        }

        public NotaFiscal Constroi() 
        {
            var nf =  new NotaFiscal(RazaoSocial, Cnpj, Data, ValorBruto, Impostos, TodosItens, Observacoes);

            new EnviadorDeEmail().EnviaPorEmail(nf);
            new NotaFiscalDao().SalvaNoBanco(nf);
            new EnviadorDeSms().EnviaPorSms(nf);

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