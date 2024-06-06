namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaTemaForm
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
            panel1 = new Panel();
            grid = new DataGridView();
            brnGravar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            CheckItem = new DataGridViewCheckBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 226, 239);
            panel1.Controls.Add(grid);
            panel1.Controls.Add(brnGravar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 543);
            panel1.TabIndex = 1;
            // 
            // grid
            // 
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = Color.FromArgb(63, 114, 175);
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Columns.AddRange(new DataGridViewColumn[] { CheckItem, Id, Descricao, Valor });
            grid.Location = new Point(20, 189);
            grid.Name = "grid";
            grid.RowHeadersWidth = 51;
            grid.Size = new Size(612, 288);
            grid.TabIndex = 11;
            // 
            // brnGravar
            // 
            brnGravar.BackColor = Color.FromArgb(249, 247, 247);
            brnGravar.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnGravar.ForeColor = Color.FromArgb(63, 114, 175);
            brnGravar.Location = new Point(356, 483);
            brnGravar.Name = "brnGravar";
            brnGravar.Size = new Size(135, 55);
            brnGravar.TabIndex = 10;
            brnGravar.Text = "Gravar";
            brnGravar.UseVisualStyleBackColor = false;
            brnGravar.Click += brnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(249, 247, 247);
            btnCancelar.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(63, 114, 175);
            btnCancelar.Location = new Point(497, 483);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 55);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(63, 114, 175);
            label3.Location = new Point(20, 146);
            label3.Name = "label3";
            label3.Size = new Size(226, 28);
            label3.TabIndex = 0;
            label3.Text = "Seleção de Itens";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(249, 247, 247);
            txtNome.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(63, 114, 175);
            txtNome.Location = new Point(112, 78);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(447, 35);
            txtNome.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(63, 114, 175);
            label2.Location = new Point(20, 81);
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
            txtId.Location = new Point(112, 16);
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
            label1.Location = new Point(65, 23);
            label1.Name = "label1";
            label1.Size = new Size(41, 28);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // CheckItem
            // 
            CheckItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CheckItem.HeaderText = "Add";
            CheckItem.MinimumWidth = 6;
            CheckItem.Name = "CheckItem";
            CheckItem.Width = 50;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 40;
            // 
            // Descricao
            // 
            Descricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Descricao.FillWeight = 191.836731F;
            Descricao.HeaderText = "Descrição do item";
            Descricao.MinimumWidth = 6;
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Resizable = DataGridViewTriState.True;
            Descricao.SortMode = DataGridViewColumnSortMode.NotSortable;
            Descricao.Width = 340;
            // 
            // Valor
            // 
            Valor.FillWeight = 8.163269F;
            Valor.HeaderText = "Valor";
            Valor.MinimumWidth = 6;
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 45, 78);
            ClientSize = new Size(672, 564);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTemaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaTemaForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView grid;
        private Button brnGravar;
        private Button btnCancelar;
        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private DataGridViewCheckBoxColumn CheckItem;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Valor;
    }
}