using FestasInfantis.WinApp.Compartilhado;
namespace FestasInfantis.WinApp.ModuloItem
{
    //variaveis
    public class Item : EntidadeBase
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool TemTema { get; set; }

        //construtor completo
        public Item(string descricao, decimal valor, bool tema)
        {
            Descricao = descricao;
            Valor = valor;
            TemTema = tema;
        }

        //contrutor para edição
        public Item(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
        //contrutor para o json
        public Item()
        {
            
        }

        //atualizando informações
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Item novo = (Item)novoRegistro;

            this.Id = novo.Id;
            this.Descricao = novo.Descricao;
            this.Valor = novo.Valor;
        }

        //validando informações
        public override List<String> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Descricao))
                erros.Add("O campo 'Descrição' é obrigatório");

            if (Descricao.Length < 3)
                erros.Add("O campo 'Descrição' deve conter no mínimo 3 caracteres");

            if (Valor < 1)
                erros.Add("O campo 'Valor' não pode receber o valor 0");

            return erros;
        }
    }
}