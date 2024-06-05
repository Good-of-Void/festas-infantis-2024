
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloItem
{
    public partial class TelaItemForm : Form
    {
        private Item item;
        public Item Item
        {
            set
            {
                this.txtId.Text = value.Id.ToString();
                this.txtDescricao.Text = value.Descricao;
                this.txtValor.Text = value.Valor.ToString();
            }
            get
            {
                return this.item;
            }
        }

        public TelaItemForm()
        {
            InitializeComponent();
        }

        private void brnGravar_Click(object sender, EventArgs e)
        {
            //pega os dados no txt
            item = new Item(
                this.txtDescricao.Text,
                Convert.ToDecimal(this.txtValor.Text));

            //valida os dados coletados
            List<string> erros = item.Validar();

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


    }
}
