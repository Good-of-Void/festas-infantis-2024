namespace FestasInfantis.Dominio.ModuloAluguel
{
    [Serializable]
    public class Endereco
    {
        public Endereco()
        {
        }
        //Construtor para o endeereço
        public Endereco(string rua, string bairro, string cidade, string estado, string numero)
        {
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Numero = numero;
        }
        //variáveis para o endereço
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Numero { get; set; }

        //atualizando as informaçoes
        public override string ToString()
        {
            return $"{Rua}, {Bairro}, {Numero}, {Cidade}, {Estado}";
        }
    }
}