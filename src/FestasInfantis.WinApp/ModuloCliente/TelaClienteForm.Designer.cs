
namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaClienteForm
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
            brnGravar = new Button();
            btnCancelar = new Button();
            TxtCPF = new MaskedTextBox();
            label4 = new Label();
            txtTelefone = new MaskedTextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 226, 239);
            panel1.Controls.Add(brnGravar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(TxtCPF);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTelefone);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 320);
            panel1.TabIndex = 0;
            // 
            // brnGravar
            // 
            brnGravar.BackColor = Color.FromArgb(249, 247, 247);
            brnGravar.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnGravar.ForeColor = Color.FromArgb(63, 114, 175);
            brnGravar.Location = new Point(290, 266);
            brnGravar.Margin = new Padding(3, 2, 3, 2);
            brnGravar.Name = "brnGravar";
            brnGravar.Size = new Size(118, 41);
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
            btnCancelar.Location = new Point(424, 266);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 41);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TxtCPF
            // 
            TxtCPF.BackColor = Color.FromArgb(249, 247, 247);
            TxtCPF.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCPF.ForeColor = Color.FromArgb(63, 114, 175);
            TxtCPF.Location = new Point(151, 124);
            TxtCPF.Margin = new Padding(3, 2, 3, 2);
            TxtCPF.Mask = "000,000,000-00";
            TxtCPF.Name = "TxtCPF";
            TxtCPF.Size = new Size(176, 30);
            TxtCPF.TabIndex = 1;
            TxtCPF.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(63, 114, 175);
            label4.Location = new Point(93, 126);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 0;
            label4.Text = "CPF";
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.FromArgb(249, 247, 247);
            txtTelefone.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.ForeColor = Color.FromArgb(63, 114, 175);
            txtTelefone.Location = new Point(151, 176);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Mask = "(99) 90000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(189, 30);
            txtTelefone.TabIndex = 2;
            txtTelefone.MaskInputRejected += txtTelefone_MaskInputRejected;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(63, 114, 175);
            label3.Location = new Point(38, 181);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 0;
            label3.Text = "Telefone";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(249, 247, 247);
            txtNome.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(63, 114, 175);
            txtNome.Location = new Point(151, 75);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(392, 30);
            txtNome.TabIndex = 0;
            txtNome.Text = "0";
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(63, 114, 175);
            label2.Location = new Point(71, 77);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(249, 247, 247);
            txtId.Enabled = false;
            txtId.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.FromArgb(63, 114, 175);
            txtId.Location = new Point(151, 28);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(52, 30);
            txtId.TabIndex = 9;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(63, 114, 175);
            label1.Location = new Point(110, 34);
            label1.Name = "label1";
            label1.Size = new Size(33, 23);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 45, 78);
            ClientSize = new Size(599, 338);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaClienteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Cliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox TxtCPF;
        private Label label4;
        private Button brnGravar;
        private Button btnCancelar;
    }
}