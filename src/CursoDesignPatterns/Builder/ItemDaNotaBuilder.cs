namespace CursoDesignPatterns.Builder
{
    using Venda;

    public class ItemDaNotaBuilder
    {
        internal string Descricao { get; private set; }
        internal double Valor { get; private set; }

        public ItemDaNotaBuilder ComDescricao(string descricao)
        {
            this.Descricao = descricao;

            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            this.Valor = valor;

            return this;
        }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(this.Descricao, this.Valor);
        }

    }
}