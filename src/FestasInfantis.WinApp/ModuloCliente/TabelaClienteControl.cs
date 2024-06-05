﻿
namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl
    {
        public TabelaClienteControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            //grid.ConfigurarGridSomenteLeitura();
            //grid.ConfigurarGridZebrado();
        }

        //precisa arrumar 
        public void AtualizarRegistros(List<Cliente> Clientes)
        {
            grid.Rows.Clear();

            foreach (Cliente c in Clientes)
                grid.Rows.Add(c.Id, c.Nome, c.Telefone, c.Nome, c.Alugueis, c.QuantidadeAlugueis);
        }

        public int ObterRegistroSelecionado()
        {
            return 0;
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Cpf", HeaderText = "Cpf" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Alugueis", HeaderText = "Alugueis" },                                             
                        };
        }
    }
}
