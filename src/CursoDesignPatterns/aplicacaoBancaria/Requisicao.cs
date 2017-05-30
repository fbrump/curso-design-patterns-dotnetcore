namespace CursoDesignPatterns.aplicacaoBancaria
{
    public class Requisicao
    {
        public Formato Formato { get; set;}
        
        public Requisicao(Formato formato)
        {
            this.Formato = formato;
        }
    }
}