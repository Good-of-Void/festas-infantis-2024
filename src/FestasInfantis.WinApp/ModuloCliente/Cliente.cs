using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{      
        public class Cliente : EntidadeBase
        {
        //variáveis clientes
            public string Nome { get; set; }

            public string Telefone { get; set; }

            public List<Aluguel> Alugueis { get; set; } = new List<Aluguel>();

            public int QuantidadeAlugueis { get { return Alugueis.Where(x => x.PagamentoConcluido).Count(); } }

            public Cliente()
            {

            }
        //construtor
            public Cliente(string nome, string telefone)
            {
                this.Nome = nome;
                this.Telefone = telefone;
            }
        //registrar aluguel no cliente
            public void RegistrarAluguel(Aluguel aluguel)
            {
                if (Alugueis == null)
                    Alugueis = new List<Aluguel>();

                if (Alugueis.Contains(aluguel))
                    return;

                Alugueis.Add(aluguel);
            }
        //atualizando informacoes
            public override void AtualizarRegistro(EntidadeBase novoRegistro)
            {
            Cliente novo = (Cliente)novoRegistro;

                this.Nome = novo.Nome;
                this.Telefone = novo.Telefone;
                this.Alugueis = novo.Alugueis;
            }

            public override string ToString()
            {
                return $"{Nome}";
            }
        //validando informações
            public override List<string> Validar()
            {
                List<string> erros = new List<string>();

                if (string.IsNullOrEmpty(Nome))
                    erros.Add("O campo 'Nome' é obrigatório");

                if (string.IsNullOrEmpty(Telefone))
                    erros.Add("O campo 'Telefone' é obrigatório");

                return erros;
            }

        //calculando desconto para o cliente
            public decimal CalcularDesconto(ConfiguracaoDesconto configuracaoDesconto)
            {
                decimal desconto = QuantidadeAlugueis * configuracaoDesconto.PorcentagemDesconto;

                if (desconto > configuracaoDesconto.PorcentagemMaxima)
                    desconto = configuracaoDesconto.PorcentagemMaxima;

                return desconto;
            }    
    }
}
