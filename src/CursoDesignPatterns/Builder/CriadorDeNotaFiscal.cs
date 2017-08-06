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

        public CriadorDeNotaFiscal()
        {
            this.Data = DateTime.Now;
        }

        public NotaFiscal Constroi() 
        {
            var nf =  new NotaFiscal(RazaoSocial, Cnpj, Data, ValorBruto, Impostos, TodosItens, Observacoes);

            enviaPorEmail(nf);
            salvaNoBanco(nf);
            enviaPorSms(nf);

            return nf;
        }

        private void enviaPorEmail(NotaFiscal nf)
        {
            Console.WriteLine("Simula - Envia por e-mail");
        }

        private void salvaNoBanco(NotaFiscal nf)
        {
            Console.WriteLine("Simula - Salva no banco.");
        }

        private void enviaPorSms(NotaFiscal nf)
        {
            Console.WriteLine("Simula - Envia por SMS.");
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