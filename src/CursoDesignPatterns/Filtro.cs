namespace CursoDesignPatterns
{
    
    using System.Collections.Generic;
    
    public abstract class Filtro
    {

        protected Filtro OutroFiltro { get; private set; }

        public Filtro(Filtro outroFiltro) 
        {
            this.OutroFiltro = outroFiltro;
        }

        public Filtro() {}

        public abstract IList<Conta> Filtra(IList<Conta> contas);

        protected IList<Conta> Proximo(IList<Conta> contas) 
        {
            if(OutroFiltro != null) return OutroFiltro.Filtra(contas);
            else return new List<Conta>();
        }
        
    }
}