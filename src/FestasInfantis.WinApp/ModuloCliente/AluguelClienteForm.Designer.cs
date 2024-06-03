namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class AluguelClienteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnOk = new Button();
            txtNome = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            Grid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            DataPagamento = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 226, 239);
            panel1.Controls.Add(Grid);
            panel1.Controls.Add(btnOk);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 516);
            panel1.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(249, 247, 247);
            btnOk.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOk.ForeColor = Color.FromArgb(63, 114, 175);
            btnOk.Location = new Point(629, 448);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(135, 55);
            btnOk.TabIndex = 10;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(249, 247, 247);
            txtNome.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(63, 114, 175);
            txtNome.Location = new Point(103, 85);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(607, 35);
            txtNome.TabIndex = 0;
            txtNome.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(63, 114, 175);
            label2.Location = new Point(11, 88);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(249, 247, 247);
            txtId.Enabled = false;
            txtId.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.FromArgb(63, 114, 175);
            txtId.Location = new Point(103, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(59, 35);
            txtId.TabIndex = 9;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(63, 114, 175);
            label1.Location = new Point(56, 30);
            label1.Name = "label1";
            label1.Size = new Size(41, 28);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // Grid
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(219, 226, 239);
            dataGridViewCellStyle1.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid.BackgroundColor = Color.FromArgb(63, 114, 175);
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.Columns.AddRange(new DataGridViewColumn[] { Id, Descricao, Valor, DataPagamento });
            Grid.Location = new Point(12, 143);
            Grid.Name = "Grid";
            Grid.RowHeadersWidth = 51;
            Grid.Size = new Size(752, 299);
            Grid.TabIndex = 11;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 51;
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descrição do Tema";
            Descricao.MinimumWidth = 6;
            Descricao.Name = "Descricao";
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.MinimumWidth = 6;
            Valor.Name = "Valor";
            // 
            // DataPagamento
            // 
            DataPagamento.HeaderText = "Data Pagamento";
            DataPagamento.MinimumWidth = 6;
            DataPagamento.Name = "DataPagamento";
            // 
            // AluguelClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 45, 78);
            ClientSize = new Size(800, 540);
            Controls.Add(panel1);
            Name = "AluguelClienteForm";
            Text = "AluguelClienteForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView Grid;
        private Button btnOk;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn DataPagamento;
    }
}