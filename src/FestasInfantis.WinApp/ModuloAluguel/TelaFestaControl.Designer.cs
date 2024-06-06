namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaFestaControl
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtData = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            txtHoraInicio = new MaskedTextBox();
            txtHoraTermino = new MaskedTextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCidade = new TextBox();
            label7 = new Label();
            txtEstado = new TextBox();
            txtRua = new TextBox();
            txtBairro = new TextBox();
            label8 = new Label();
            txtNumero = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHoraTermino);
            groupBox1.Controls.Add(txtHoraInicio);
            groupBox1.Controls.Add(txtData);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(63, 114, 175);
            groupBox1.Location = new Point(26, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(712, 216);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data e Hora";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(63, 114, 175);
            label1.Location = new Point(47, 54);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 10;
            label1.Text = "Data da Festa";
            // 
            // txtData
            // 
            txtData.CalendarTitleForeColor = Color.AliceBlue;
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(240, 49);
            txtData.Name = "txtData";
            txtData.Size = new Size(250, 35);
            txtData.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(63, 114, 175);
            label2.Location = new Point(39, 111);
            label2.Name = "label2";
            label2.Size = new Size(195, 28);
            label2.TabIndex = 10;
            label2.Text = "Hora de Inicío";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(63, 114, 175);
            label3.Location = new Point(8, 168);
            label3.Name = "label3";
            label3.Size = new Size(226, 28);
            label3.TabIndex = 10;
            label3.Text = "Hora de Termino";
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.BackColor = Color.FromArgb(249, 247, 247);
            txtHoraInicio.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoraInicio.ForeColor = Color.FromArgb(63, 114, 175);
            txtHoraInicio.Location = new Point(240, 108);
            txtHoraInicio.Mask = "00:00";
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.Size = new Size(82, 35);
            txtHoraInicio.TabIndex = 12;
            txtHoraInicio.ValidatingType = typeof(DateTime);
            // 
            // txtHoraTermino
            // 
            txtHoraTermino.BackColor = Color.FromArgb(249, 247, 247);
            txtHoraTermino.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoraTermino.ForeColor = Color.FromArgb(63, 114, 175);
            txtHoraTermino.Location = new Point(240, 165);
            txtHoraTermino.Mask = "00:00";
            txtHoraTermino.Name = "txtHoraTermino";
            txtHoraTermino.Size = new Size(82, 35);
            txtHoraTermino.TabIndex = 12;
            txtHoraTermino.ValidatingType = typeof(DateTime);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtBairro);
            groupBox2.Controls.Add(txtRua);
            groupBox2.Controls.Add(txtEstado);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtCidade);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(63, 114, 175);
            groupBox2.Location = new Point(26, 262);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(712, 216);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(63, 114, 175);
            label4.Location = new Point(7, 165);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 10;
            label4.Text = "Bairro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(63, 114, 175);
            label5.Location = new Point(19, 104);
            label5.Name = "label5";
            label5.Size = new Size(61, 28);
            label5.TabIndex = 10;
            label5.Text = "Rua";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(63, 114, 175);
            label6.Location = new Point(19, 46);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 10;
            label6.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.BackColor = Color.FromArgb(249, 247, 247);
            txtCidade.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCidade.ForeColor = Color.FromArgb(63, 114, 175);
            txtCidade.Location = new Point(124, 43);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(269, 35);
            txtCidade.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(63, 114, 175);
            label7.Location = new Point(410, 46);
            label7.Name = "label7";
            label7.Size = new Size(99, 28);
            label7.TabIndex = 12;
            label7.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.BackColor = Color.FromArgb(249, 247, 247);
            txtEstado.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstado.ForeColor = Color.FromArgb(63, 114, 175);
            txtEstado.Location = new Point(515, 46);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(178, 35);
            txtEstado.TabIndex = 13;
            // 
            // txtRua
            // 
            txtRua.BackColor = Color.FromArgb(249, 247, 247);
            txtRua.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRua.ForeColor = Color.FromArgb(63, 114, 175);
            txtRua.Location = new Point(124, 101);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(569, 35);
            txtRua.TabIndex = 14;
            // 
            // txtBairro
            // 
            txtBairro.BackColor = Color.FromArgb(249, 247, 247);
            txtBairro.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBairro.ForeColor = Color.FromArgb(63, 114, 175);
            txtBairro.Location = new Point(124, 165);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(269, 35);
            txtBairro.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(63, 114, 175);
            label8.Location = new Point(410, 168);
            label8.Name = "label8";
            label8.Size = new Size(113, 28);
            label8.TabIndex = 16;
            label8.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(249, 247, 247);
            txtNumero.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero.ForeColor = Color.FromArgb(63, 114, 175);
            txtNumero.Location = new Point(529, 168);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(164, 35);
            txtNumero.TabIndex = 17;
            // 
            // TelaFestaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 226, 239);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TelaFestaControl";
            Size = new Size(769, 514);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker txtData;
        private Label label1;
        private Label label3;
        private Label label2;
        private MaskedTextBox txtHoraTermino;
        private MaskedTextBox txtHoraInicio;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNumero;
        private Label label8;
        private TextBox txtBairro;
        private TextBox txtRua;
        private TextBox txtEstado;
        private Label label7;
        private TextBox txtCidade;
    }
}
