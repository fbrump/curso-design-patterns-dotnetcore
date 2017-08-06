namespace CursoDesignPatterns.Builder
{
    using System;
    using System.Collections.Generic;
    using CursoDesignPatterns.Venda;

    public class CriadorDeNotaFiscal
    {
        private String RazaoSocial;
        private String Cnpj;
        private double ValorTotal;
        private double Impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public void ParaEmpresa(String razaoSocial) 
        {
            this.RazaoSocial = razaoSocial;
        }

        public void ComCnpj(String cnpj) 
        {
            this.Cnpj = cnpj;
        }

        public void comItem(ItemDaNota item) 
        {
            todosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
        }
    }
}