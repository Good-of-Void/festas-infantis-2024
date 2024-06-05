using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.Dominio.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Aluguel : EntidadeBase
        //Declarando as variáveis
    {
        public Cliente Cliente { get; set; }
        public Festa Festa { get; set; }
        public Tema Tema { get; set; }
        public decimal ValorEntrada { get; set; }
        public decimal ValorDesconto { get; set; }
        public DateTime? DataPagamento { get; set; }
        public bool PagamentoConcluido { get; set; }

        public Aluguel ()
        {

        }

        //Construtor
        public Aluguel(Cliente cliente, Festa festa, Tema tema, decimal valorentrada, decimal valordesconto)
        {
            Cliente = cliente;
            Festa = festa;
            Tema = tema;
            ValorEntrada = valorentrada;
            ValorDesconto = valordesconto;
            PagamentoConcluido = false;
            DataPagamento = null;
        }
        //Calculos, valor pendente, valor de entrada, desconto e concluindo o pagamento.
        public decimal CalcularValorPendente()
        {
            return CalcularValorDesconto() - CalcularValorEntrada();
        }

        public decimal CalcularValorEntrada()
        {
            return 0;
        }

        public decimal CalcularValorDesconto()
        {
            return 0;
        }

        public void Concluir()
        {
            DataPagamento = DateTime.Now;
            PagamentoConcluido = true;
        }
        //att informações
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Aluguel novo = (Aluguel)novoRegistro;

            this.Cliente = novo.Cliente;
            this.Festa = novo.Festa;
            this.Tema = novo.Tema;
            this.ValorDesconto = novo.ValorDesconto;
            this.ValorEntrada = novo.ValorEntrada;
            this.DataPagamento = novo.DataPagamento;
            this.PagamentoConcluido = novo.PagamentoConcluido;
        }
        //validando as informações digitadas
        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            erros.AddRange(Festa.Validar());

            if (Cliente == null)
                erros.Add("O campo 'Cliente' é obrigatório");

            if (Tema == null)
                erros.Add("O campo 'Tema' é obrigatório");

            if (ValorEntrada <= 0)
                erros.Add("O campo '% do Sinal' é obrigatório");

            return erros;
        }
    }
}