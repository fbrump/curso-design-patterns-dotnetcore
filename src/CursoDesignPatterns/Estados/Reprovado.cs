namespace CursoDesignPatterns.Estados
{
    using System;
    using Interface;

    public class Reprovado: IEstadoDeUmOrcamento 
    { 
        public void AplicaDescontoExtra(Orcamento orcamento) 
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento) 
        {
            // jah estou em aprovacao
            throw new Exception("Orçamento já está em estado de reprovacao e não pode ser aprovado");
        }

        public void Reprova(Orcamento orcamento) 
        {
            // nao pode ser reprovado agora!
            throw new Exception("Orçamento está em estado de reprovacao");
        }

        public void Finaliza(Orcamento orcamento) 
        {
            // daqui posso ir para o estado de finalizado
            orcamento.EstadoAtual = new Finalizado();
        }

    }
}