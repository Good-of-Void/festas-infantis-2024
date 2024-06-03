namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ConfiguracaoDesconto
    {
        //variáveis
        public decimal PorcentagemDesconto { get; set; }
        public decimal PorcentagemMaxima { get; set; }

        //descontos
        public ConfiguracaoDesconto()
        {
            PorcentagemDesconto = 1m;
            PorcentagemMaxima = 15;
        }

        public ConfiguracaoDesconto(decimal porcentagemPorDesconto, decimal porcentagemMaxima)
        {
            PorcentagemDesconto = porcentagemPorDesconto;
            PorcentagemMaxima = porcentagemMaxima;
        }
        //validando os descontos
        public List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (PorcentagemDesconto > PorcentagemMaxima)
                erros.Add("A porcentagem de desconto não pode ultrapassar a porcentagem máxima!");

            return erros;
        }
    }
}