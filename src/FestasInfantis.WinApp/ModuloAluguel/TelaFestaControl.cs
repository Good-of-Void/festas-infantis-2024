using FestasInfantis.Dominio.ModuloAluguel;


namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaFestaControl : UserControl
    {
        private Festa festa;
        public Festa Festa
        {
            set
            {

            }
            get
            {
                PegarDadosFesta();

                return this.festa;
            }
        }

        private void PegarDadosFesta()
        {
            festa = new Festa();
            festa.Data = txtData.Value;
            festa.HorarioInicio = TimeSpan.Parse(txtHoraInicio.Text);
            festa.HorarioTermino = TimeSpan.Parse(txtHoraTermino.Text);
            festa.Endereco = PegarDadosEndereco();
        }

        private Endereco PegarDadosEndereco()
        {
            Endereco endereco = new Endereco();
            endereco.Cidade = txtCidade.Text;
            endereco.Estado = txtEstado.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Rua = txtRua.Text;
            endereco.Numero = txtNumero.Text;

            return endereco;
        }

        public TelaFestaControl()
        {
            InitializeComponent();
        }
    }
}
