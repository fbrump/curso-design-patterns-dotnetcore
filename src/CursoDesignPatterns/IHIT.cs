namespace CursoDesignPatterns
{
    using System.Linq;
    public class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento) 
        => orcamento.Itens?.GroupBy(t => t.Nome)
            .Select(g => new { name=g.Key, count=g.Count()})
            .Where(t => t.count >=2)
            .Count() >=2;
        public override double MaximaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.13 + 100;
        public override double MinimaTaxacao(Orcamento orcamento) =>orcamento.Valor * 0.01;

    }
}