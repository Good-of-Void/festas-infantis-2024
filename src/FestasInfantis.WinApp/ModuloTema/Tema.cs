using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string nome;
        //variaveis
        public List<Item> Itens { get; set; }

        public Tema(string descricao)
        {
            nome = descricao;
        }
        //add itens e somando valor do total de itens
        public void AdicionarItem(Item item)
        {
            if (Itens == null)
                Itens = new List<Item>();

            Itens.Add(item);
        }

        public decimal CalcularValor()
        {
            return Itens.Aggregate(0m, (soma, item) => soma + item.Valor);
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
            this.nome = novo.nome;
            this.Itens = novo.Itens;
        }

        public override string ToString()
        {
            return $"{nome}";
        }
        //validando informações
        public override List<String> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'Nome' é obrigatório");

            if (nome.Length < 3)
                erros.Add("O campo 'Nome' deve conter no mínimo 3 caracteres");

            if (CalcularValor() < 1)
                erros.Add("O campo 'Valor' não pode receber o valor 0");

            return erros;
        }
    }
}