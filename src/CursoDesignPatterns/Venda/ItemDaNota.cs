namespace CursoDesignPatterns.Venda
{
    public class ItemDaNota
    {

        public ItemDaNota(string descricao, double valor)
        {
            this.Descricao = descricao;
            this.Valor = valor;
        }

        internal string Descricao {get; private set; }
        internal double Valor { get; set; }

    }
}