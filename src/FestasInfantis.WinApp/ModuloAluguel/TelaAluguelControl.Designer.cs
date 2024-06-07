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
            label1 = new Label();
            label3 = new Label();
            cboxEntrada = new ComboBox();
            cboxTema = new ComboBox();
            cboxCliente = new ComboBox();
            label4 = new Label();
            btnCalcular = new Button();
            gboxDadosPagamento = new GroupBox();
            txtValorTotal = new TextBox();
            txtPedente = new TextBox();
            label9 = new Label();
            txtValorEntrada = new TextBox();
            txtTemaDesconto = new TextBox();
            txtValorTema = new TextBox();
            txtDesconto = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            gboxDadosPagamento.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(219, 226, 239);
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(63, 114, 175);
            label2.Location = new Point(17, 44);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(219, 226, 239);
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(63, 114, 175);
            label1.Location = new Point(436, 44);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 2;
            label1.Text = "Tema";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(219, 226, 239);
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(63, 114, 175);
            label3.Location = new Point(17, 112);
            label3.Name = "label3";
            label3.Size = new Size(186, 28);
            label3.TabIndex = 2;
            label3.Text = "% da entrada";
            // 
            // cboxEntrada
            // 
            cboxEntrada.BackColor = Color.FromArgb(249, 247, 247);
            cboxEntrada.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxEntrada.ForeColor = Color.FromArgb(63, 114, 175);
            cboxEntrada.Items.AddRange(new object[] { "00", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
            cboxEntrada.Location = new Point(209, 108);
            cboxEntrada.Margin = new Padding(3, 4, 3, 4);
            cboxEntrada.Name = "cboxEntrada";
            cboxEntrada.Size = new Size(104, 37);
            cboxEntrada.TabIndex = 2;
            // 
            // cboxTema
            // 
            cboxTema.BackColor = Color.FromArgb(249, 247, 247);
            cboxTema.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxTema.ForeColor = Color.FromArgb(63, 114, 175);
            cboxTema.Location = new Point(524, 40);
            cboxTema.Margin = new Padding(3, 4, 3, 4);
            cboxTema.Name = "cboxTema";
            cboxTema.Size = new Size(225, 37);
            cboxTema.TabIndex = 1;
            // 
            // cboxCliente
            // 
            cboxCliente.BackColor = Color.FromArgb(249, 247, 247);
            cboxCliente.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxCliente.ForeColor = Color.FromArgb(63, 114, 175);
            cboxCliente.Location = new Point(124, 40);
            cboxCliente.Margin = new Padding(3, 4, 3, 4);
            cboxCliente.Name = "cboxCliente";
            cboxCliente.Size = new Size(294, 37);
            cboxCliente.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(63, 114, 175);
            label4.Location = new Point(44, 49);
            label4.Name = "label4";
            label4.Size = new Size(211, 28);
            label4.TabIndex = 2;
            label4.Text = "% De Desconto";
            // 
            // btnCalcular
            // 
            btnCalcular.BackgroundImageLayout = ImageLayout.None;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.FromArgb(63, 114, 175);
            btnCalcular.Image = Properties.Resources.cifrao;
            btnCalcular.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalcular.Location = new Point(542, 104);
            btnCalcular.Margin = new Padding(5);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(176, 56);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "   Calcular";
            btnCalcular.TextAlign = ContentAlignment.MiddleLeft;
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // gboxDadosPagamento
            // 
            gboxDadosPagamento.BackColor = Color.FromArgb(219, 226, 239);
            gboxDadosPagamento.Controls.Add(txtValorTotal);
            gboxDadosPagamento.Controls.Add(txtPedente);
            gboxDadosPagamento.Controls.Add(label9);
            gboxDadosPagamento.Controls.Add(txtValorEntrada);
            gboxDadosPagamento.Controls.Add(txtTemaDesconto);
            gboxDadosPagamento.Controls.Add(txtValorTema);
            gboxDadosPagamento.Controls.Add(txtDesconto);
            gboxDadosPagamento.Controls.Add(label6);
            gboxDadosPagamento.Controls.Add(label8);
            gboxDadosPagamento.Controls.Add(label5);
            gboxDadosPagamento.Controls.Add(label7);
            gboxDadosPagamento.Controls.Add(label4);
            gboxDadosPagamento.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gboxDadosPagamento.ForeColor = Color.FromArgb(63, 114, 175);
            gboxDadosPagamento.Location = new Point(19, 195);
            gboxDadosPagamento.Margin = new Padding(3, 4, 3, 4);
            gboxDadosPagamento.Name = "gboxDadosPagamento";
            gboxDadosPagamento.Padding = new Padding(3, 4, 3, 4);
            gboxDadosPagamento.Size = new Size(732, 306);
            gboxDadosPagamento.TabIndex = 4;
            gboxDadosPagamento.TabStop = false;
            gboxDadosPagamento.Text = "Dados Pagamento";
            // 
            // txtValorTotal
            // 
            txtValorTotal.BackColor = Color.FromArgb(249, 247, 247);
            txtValorTotal.Enabled = false;
            txtValorTotal.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorTotal.ForeColor = Color.FromArgb(63, 114, 175);
            txtValorTotal.Location = new Point(178, 252);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(166, 35);
            txtValorTotal.TabIndex = 10;
            // 
            // txtPedente
            // 
            txtPedente.BackColor = Color.FromArgb(249, 247, 247);
            txtPedente.Enabled = false;
            txtPedente.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPedente.ForeColor = Color.FromArgb(63, 114, 175);
            txtPedente.Location = new Point(574, 184);
            txtPedente.Name = "txtPedente";
            txtPedente.Size = new Size(140, 35);
            txtPedente.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(63, 114, 175);
            label9.Location = new Point(374, 187);
            label9.Name = "label9";
            label9.Size = new Size(191, 28);
            label9.TabIndex = 8;
            label9.Text = "Valor pedente";
            // 
            // txtValorEntrada
            // 
            txtValorEntrada.BackColor = Color.FromArgb(249, 247, 247);
            txtValorEntrada.Enabled = false;
            txtValorEntrada.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorEntrada.ForeColor = Color.FromArgb(63, 114, 175);
            txtValorEntrada.Location = new Point(178, 184);
            txtValorEntrada.Name = "txtValorEntrada";
            txtValorEntrada.Size = new Size(169, 35);
            txtValorEntrada.TabIndex = 7;
            // 
            // txtTemaDesconto
            // 
            txtTemaDesconto.BackColor = Color.FromArgb(249, 247, 247);
            txtTemaDesconto.Enabled = false;
            txtTemaDesconto.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTemaDesconto.ForeColor = Color.FromArgb(63, 114, 175);
            txtTemaDesconto.Location = new Point(574, 114);
            txtTemaDesconto.Name = "txtTemaDesconto";
            txtTemaDesconto.Size = new Size(140, 35);
            txtTemaDesconto.TabIndex = 6;
            // 
            // txtValorTema
            // 
            txtValorTema.BackColor = Color.FromArgb(249, 247, 247);
            txtValorTema.Enabled = false;
            txtValorTema.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorTema.ForeColor = Color.FromArgb(63, 114, 175);
            txtValorTema.Location = new Point(178, 114);
            txtValorTema.Name = "txtValorTema";
            txtValorTema.Size = new Size(169, 35);
            txtValorTema.TabIndex = 5;
            // 
            // txtDesconto
            // 
            txtDesconto.BackColor = Color.FromArgb(249, 247, 247);
            txtDesconto.Enabled = false;
            txtDesconto.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesconto.ForeColor = Color.FromArgb(63, 114, 175);
            txtDesconto.Location = new Point(261, 49);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(86, 35);
            txtDesconto.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(63, 114, 175);
            label6.Location = new Point(16, 255);
            label6.Name = "label6";
            label6.Size = new Size(147, 28);
            label6.TabIndex = 2;
            label6.Text = "Valor total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(63, 114, 175);
            label8.Location = new Point(44, 172);
            label8.Name = "label8";
            label8.Size = new Size(119, 56);
            label8.TabIndex = 2;
            label8.Text = "Valor da\r\nentrada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(63, 114, 175);
            label5.Location = new Point(44, 103);
            label5.Name = "label5";
            label5.Size = new Size(128, 56);
            label5.TabIndex = 2;
            label5.Text = "Valor do \r\ntema";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(63, 114, 175);
            label7.Location = new Point(374, 103);
            label7.Name = "label7";
            label7.Size = new Size(194, 56);
            label7.TabIndex = 2;
            label7.Text = "Valor tema \r\ncom Desconto";
            // 
            // TelaAluguelControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 226, 239);
            Controls.Add(gboxDadosPagamento);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(cboxCliente);
            Controls.Add(cboxTema);
            Controls.Add(cboxEntrada);
            Controls.Add(label2);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaAluguelControl";
            Size = new Size(769, 514);
            gboxDadosPagamento.ResumeLayout(false);
            gboxDadosPagamento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox cboxEntrada;
        private ComboBox cboxTema;
        private ComboBox cboxCliente;
        private Label label4;
        private Button btnCalcular;
        private GroupBox gboxDadosPagamento;
        private Label label6;
        private Label label8;
        private Label label7;
        private TextBox txtDesconto;
        private TextBox txtTemaDesconto;
        private TextBox txtValorEntrada;
        private TextBox txtValorTotal;
        private TextBox txtPedente;
        private Label label9;
        private TextBox txtValorTema;
        private Label label5;
    }
}
