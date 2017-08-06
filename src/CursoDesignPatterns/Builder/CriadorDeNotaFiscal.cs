namespace CursoDesignPatterns.Builder
{
    using System;
    using System.Collections.Generic;
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

        public NotaFiscal Constroi() 
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorBruto, Impostos, TodosItens, Observacoes);
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

        public CriadorDeNotaFiscal ComItem(ItemDaNota item) 
        {
            TodosItens.Add(item);
            ValorBruto += item.Valor;
            Impostos += item.Valor * 0.05;

            return this;
        }

        public CriadorDeNotaFiscal NaDataAtual() 
        {
            this.Data = DateTime.Now;

            return this;
        }

    }
}