namespace CursoDesignPatterns.aplicacaoBancaria.interfaces
{
    public interface Resposta
    {
         void Resposta(Requisicao req, ContaBancaria conta);
         Resposta Proxima {get; set; }
    }
}