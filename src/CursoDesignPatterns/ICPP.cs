namespace CursoDesignPatterns
{
    public class ICPP : TemplateDeImpostoCondicional
     {

         public ICPP(Imposto outroImposto) : base(outroImposto) { }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento) => orcamento.Valor >= 500;
        public override double MaximaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.07;
        public override double MinimaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.05;
        
    }
}