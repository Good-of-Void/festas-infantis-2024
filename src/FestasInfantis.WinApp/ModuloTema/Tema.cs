using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloItem;
using System.Numerics;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        //variaveis
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public List<Item> Itens { get; set; }
        public List<Aluguel> HistoriocoAlugueis { get; set; }

        //contrutor vazil para o json
        public Tema() { }

        //contrutor para o cadastro
        public Tema(string nome, List<Item> itens)
        {
            Nome = nome;
            Itens = itens;
            HistoriocoAlugueis = new List<Aluguel>();
            Valor = CalcularValor(itens);
        }

        //add itens e somando valor do total de itens
        public void AdicionarItem(Item item)
        {
            if (Itens == null)
                Itens = new List<Item>();

            Itens.Add(item);
        }

        public void AtualizarItens(List<Item> itens)
        {
            Itens = itens;
        }
        //atualizando registros dos temas
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema novo = (Tema)novoRegistro;

            this.Id = novo.Id;
            this.Nome = novo.Nome;
            this.Itens = novo.Itens;
            this.HistoriocoAlugueis = novo.HistoriocoAlugueis;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
        //validando informações
        public override List<String> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome))
                erros.Add("O campo 'Nome' é obrigatório");

            if (Nome.Length < 3)
                erros.Add("O campo 'Nome' deve conter no mínimo 3 caracteres");

            if (this.Itens.Count == 0)
                erros.Add("Precisa selecionar pelomenos um item para o tema");

            return erros;
        }

        //responsavel por calcular o valor total do tema
        private decimal CalcularValor(List<Item> itens)
        {
            decimal total = 0;
            foreach (Item i in itens)
                total += i.Valor;

            return total;
        }
    }
}