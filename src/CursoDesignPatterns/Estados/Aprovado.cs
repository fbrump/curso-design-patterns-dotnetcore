namespace CursoDesignPatterns.Estados
{
    using System;
    using Interface;

    public class Aprovado : IEstadoDeUmOrcamento 
    { 
        private bool descontoAplicado = false;
        
        public void AplicaDescontoExtra(Orcamento orcamento) 
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
            if(!descontoAplicado) 
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoAplicado = true;
            }
            else 
                throw new Exception("Desconto já aplicado!");
        }

        public void Aprova(Orcamento orcamento) 
        {
            // jah estou em aprovacao
            throw new Exception("Orçamento já está em estado de aprovação");
        }

        public void Reprova(Orcamento orcamento) 
        {
            // nao pode ser reprovado agora!
            throw new Exception("Orçamento está em estado de aprovação e não pode ser reprovado");
        }

        public void Finaliza(Orcamento orcamento) 
        {
            // daqui posso ir para o estado de finalizado
            orcamento.EstadoAtual = new Finalizado();
        }

    }
}