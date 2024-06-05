
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private Tema tema;
        public IRepositorioItem repositorioItem;

        public Tema Tema {
            get
            { 
            return this.tema;
            }
            set 
            {
                this.txtId.Text = value.Id.ToString();
                this.txtNome.Text = value.Nome;
            } 
        }
        public TelaTemaForm()
        {
            InitializeComponent();

            //ver depois
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        //Eventos botoes
        private void brnGravar_Click(object sender, EventArgs e)
        {
            //pega os dados no txt
            tema = new Tema(
                this.txtNome.Text,
                this.ObterItensSelecionados(repositorioItem)
                );

            //validar os dados coletados
            List<string> erros = tema.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void AtualizarGrid(List<Item> itens)
        {
            grid.Rows.Clear();

            foreach (Item i in itens)
                grid.Rows.Add(false,i.Id, i.Descricao, i.Valor);
        }

        private List<Item> ObterItensSelecionados(IRepositorioItem item)
        {
            List<Item> itens = new List<Item>();

            foreach (DataGridViewRow linha in grid.Rows)
            {
                bool selecionado = Convert.ToBoolean(linha.Cells["CheckItem"].Value);

                if (selecionado)
                {
                    int id = Convert.ToInt32(linha.Cells["Id"].Value);
                    Item add = item.SelecionarPorId(id);

                    itens.Add(add);
                }
            }
            return itens;
        }
    }
}
