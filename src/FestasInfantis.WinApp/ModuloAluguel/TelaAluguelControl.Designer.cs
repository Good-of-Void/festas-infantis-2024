namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaAluguelControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            cboxNome = new ComboBox();
            label1 = new Label();
            cboxTema = new ComboBox();
            label3 = new Label();
            cboxSinal = new ComboBox();
            gboxDadosPagamento = new GroupBox();
            btnCalcular = new Button();
            label6 = new Label();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            btnGravar = new Button();
            btnCancelar = new Button();
            cboxValorPendente = new ComboBox();
            cboxValorComDesconto = new ComboBox();
            cboxValorSinal = new ComboBox();
            cboxValorTema = new ComboBox();
            cboxPorcentagemDesconto = new ComboBox();
            gboxDadosPagamento.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(219, 226, 239);
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(63, 114, 175);
            label2.Location = new Point(16, 33);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // cboxNome
            // 
            cboxNome.BackColor = Color.FromArgb(249, 247, 247);
            cboxNome.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxNome.ForeColor = Color.FromArgb(63, 114, 175);
            cboxNome.Location = new Point(94, 30);
            cboxNome.Name = "cboxNome";
            cboxNome.Size = new Size(121, 31);
            cboxNome.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(219, 226, 239);
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(63, 114, 175);
            label1.Location = new Point(252, 32);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 2;
            label1.Text = "Tema";
            // 
            // cboxTema
            // 
            cboxTema.BackColor = Color.FromArgb(249, 247, 247);
            cboxTema.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxTema.ForeColor = Color.FromArgb(63, 114, 175);
            cboxTema.Location = new Point(327, 29);
            cboxTema.Name = "cboxTema";
            cboxTema.Size = new Size(121, 31);
            cboxTema.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(219, 226, 239);
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(63, 114, 175);
            label3.Location = new Point(484, 33);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 2;
            label3.Text = "Sinal";
            // 
            // cboxSinal
            // 
            cboxSinal.BackColor = Color.FromArgb(249, 247, 247);
            cboxSinal.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxSinal.ForeColor = Color.FromArgb(63, 114, 175);
            cboxSinal.Location = new Point(559, 29);
            cboxSinal.Name = "cboxSinal";
            cboxSinal.Size = new Size(121, 31);
            cboxSinal.TabIndex = 3;
            // 
            // gboxDadosPagamento
            // 
            gboxDadosPagamento.BackColor = Color.FromArgb(219, 226, 239);
            gboxDadosPagamento.Controls.Add(btnCalcular);
            gboxDadosPagamento.Controls.Add(cboxValorSinal);
            gboxDadosPagamento.Controls.Add(label6);
            gboxDadosPagamento.Controls.Add(cboxValorPendente);
            gboxDadosPagamento.Controls.Add(cboxValorTema);
            gboxDadosPagamento.Controls.Add(label8);
            gboxDadosPagamento.Controls.Add(label5);
            gboxDadosPagamento.Controls.Add(cboxValorComDesconto);
            gboxDadosPagamento.Controls.Add(label7);
            gboxDadosPagamento.Controls.Add(cboxPorcentagemDesconto);
            gboxDadosPagamento.Controls.Add(label4);
            gboxDadosPagamento.Location = new Point(40, 116);
            gboxDadosPagamento.Name = "gboxDadosPagamento";
            gboxDadosPagamento.Size = new Size(683, 314);
            gboxDadosPagamento.TabIndex = 4;
            gboxDadosPagamento.TabStop = false;
            gboxDadosPagamento.Text = "Dados Pagamento";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(23, 42);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(115, 46);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(63, 114, 175);
            label6.Location = new Point(194, 152);
            label6.Name = "label6";
            label6.Size = new Size(170, 23);
            label6.TabIndex = 2;
            label6.Text = "Valor do Sinal:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(63, 114, 175);
            label8.Location = new Point(194, 270);
            label8.Name = "label8";
            label8.Size = new Size(185, 23);
            label8.TabIndex = 2;
            label8.Text = "Valor Pendente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(63, 114, 175);
            label5.Location = new Point(194, 93);
            label5.Name = "label5";
            label5.Size = new Size(170, 23);
            label5.TabIndex = 2;
            label5.Text = "Valor do tema:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(63, 114, 175);
            label7.Location = new Point(194, 212);
            label7.Name = "label7";
            label7.Size = new Size(233, 23);
            label7.TabIndex = 2;
            label7.Text = "Valor com Desconto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(63, 114, 175);
            label4.Location = new Point(194, 42);
            label4.Name = "label4";
            label4.Size = new Size(185, 23);
            label4.TabIndex = 2;
            label4.Text = "% De Desconto:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 226, 239);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(cboxNome);
            panel1.Controls.Add(cboxSinal);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboxTema);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 479);
            panel1.TabIndex = 5;
            // 
            // btnGravar
            // 
            btnGravar.BackColor = Color.FromArgb(249, 247, 247);
            btnGravar.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGravar.ForeColor = Color.FromArgb(63, 114, 175);
            btnGravar.Location = new Point(450, 417);
            btnGravar.Margin = new Padding(3, 2, 3, 2);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(118, 41);
            btnGravar.TabIndex = 11;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(249, 247, 247);
            btnCancelar.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(63, 114, 175);
            btnCancelar.Location = new Point(584, 417);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 41);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // cboxValorPendente
            // 
            cboxValorPendente.BackColor = Color.FromArgb(249, 247, 247);
            cboxValorPendente.Font = new Font("Verdana", 14.25F);
            cboxValorPendente.ForeColor = Color.FromArgb(63, 114, 175);
            cboxValorPendente.Location = new Point(426, 270);
            cboxValorPendente.Name = "cboxValorPendente";
            cboxValorPendente.Size = new Size(121, 31);
            cboxValorPendente.TabIndex = 3;
            cboxValorPendente.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // cboxValorComDesconto
            // 
            cboxValorComDesconto.BackColor = Color.FromArgb(249, 247, 247);
            cboxValorComDesconto.Font = new Font("Verdana", 14.25F);
            cboxValorComDesconto.ForeColor = Color.FromArgb(63, 114, 175);
            cboxValorComDesconto.Location = new Point(426, 209);
            cboxValorComDesconto.Name = "cboxValorComDesconto";
            cboxValorComDesconto.Size = new Size(121, 31);
            cboxValorComDesconto.TabIndex = 3;
            cboxValorComDesconto.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // cboxValorSinal
            // 
            cboxValorSinal.BackColor = Color.FromArgb(249, 247, 247);
            cboxValorSinal.Font = new Font("Verdana", 14.25F);
            cboxValorSinal.ForeColor = Color.FromArgb(63, 114, 175);
            cboxValorSinal.Location = new Point(426, 152);
            cboxValorSinal.Name = "cboxValorSinal";
            cboxValorSinal.Size = new Size(121, 31);
            cboxValorSinal.TabIndex = 3;
            // 
            // cboxValorTema
            // 
            cboxValorTema.BackColor = Color.FromArgb(249, 247, 247);
            cboxValorTema.Font = new Font("Verdana", 14.25F);
            cboxValorTema.ForeColor = Color.FromArgb(63, 114, 175);
            cboxValorTema.Location = new Point(426, 93);
            cboxValorTema.Name = "cboxValorTema";
            cboxValorTema.Size = new Size(121, 31);
            cboxValorTema.TabIndex = 3;
            // 
            // cboxPorcentagemDesconto
            // 
            cboxPorcentagemDesconto.BackColor = Color.FromArgb(249, 247, 247);
            cboxPorcentagemDesconto.Font = new Font("Verdana", 14.25F);
            cboxPorcentagemDesconto.ForeColor = Color.FromArgb(63, 114, 175);
            cboxPorcentagemDesconto.Location = new Point(426, 34);
            cboxPorcentagemDesconto.Name = "cboxPorcentagemDesconto";
            cboxPorcentagemDesconto.Size = new Size(121, 31);
            cboxPorcentagemDesconto.TabIndex = 3;
            // 
            // TelaAluguelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 114, 175);
            Controls.Add(gboxDadosPagamento);
            Controls.Add(panel1);
            Name = "TelaAluguelControl";
            Size = new Size(769, 514);
            gboxDadosPagamento.ResumeLayout(false);
            gboxDadosPagamento.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private ComboBox cboxNome;
        private Label label1;
        private ComboBox cboxTema;
        private Label label3;
        private ComboBox cboxSinal;
        private GroupBox gboxDadosPagamento;
        private Label label4;
        private Button btnCalcular;
        private Label label6;
        private Label label8;
        private Label label5;
        private Label label7;
        private Panel panel1;
        private Button btnGravar;
        private Button btnCancelar;
        private ComboBox cboxValorSinal;
        private ComboBox cboxValorPendente;
        private ComboBox cboxValorTema;
        private ComboBox cboxValorComDesconto;
        private ComboBox cboxPorcentagemDesconto;
    }
}
