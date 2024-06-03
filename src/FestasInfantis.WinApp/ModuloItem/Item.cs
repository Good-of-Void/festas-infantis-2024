using FestasInfantis.WinApp.Compartilhado;
namespace FestasInfantis.WinApp.ModuloItem
{
    //variaveis
    public class Item : EntidadeBase
    {
        public string descricao;
        public decimal valor;
        //construtor
        public Item(string descricao, decimal valor)
        {
            this.descricao = descricao;
            this.valor = valor;
        }
        //atualizando informações
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Item novo = (Item)novoRegistro;

            this.Id = novo.Id;
            this.descricao = novo.descricao;
            this.valor = novo.valor;
        }
        //validando informações
        public override List<String> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(descricao))
                erros.Add("O campo 'Descrição' é obrigatório");

            if (descricao.Length < 3)
                erros.Add("O campo 'Descrição' deve conter no mínimo 3 caracteres");

            if (valor < 1)
                erros.Add("O campo 'Valor' não pode receber o valor 0");

            return erros;
        }

        public override string ToString()
        {
            return $"Id: {Id} Descrição: {descricao} Valor: {valor}";
        }
 
    }
}