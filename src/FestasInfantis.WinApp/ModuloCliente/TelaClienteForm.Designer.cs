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
            maskedTextBox1 = new MaskedTextBox();
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
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTelefone);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 426);
            panel1.TabIndex = 0;
            // 
            // brnGravar
            // 
            brnGravar.BackColor = Color.FromArgb(249, 247, 247);
            brnGravar.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnGravar.ForeColor = Color.FromArgb(63, 114, 175);
            brnGravar.Location = new Point(331, 355);
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
            btnCancelar.Location = new Point(485, 355);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 55);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.FromArgb(249, 247, 247);
            maskedTextBox1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox1.ForeColor = Color.FromArgb(63, 114, 175);
            maskedTextBox1.Location = new Point(173, 165);
            maskedTextBox1.Mask = "000,000,000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(201, 35);
            maskedTextBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(63, 114, 175);
            label4.Location = new Point(106, 168);
            label4.Name = "label4";
            label4.Size = new Size(61, 28);
            label4.TabIndex = 0;
            label4.Text = "CPF";
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.FromArgb(249, 247, 247);
            txtTelefone.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.ForeColor = Color.FromArgb(63, 114, 175);
            txtTelefone.Location = new Point(173, 234);
            txtTelefone.Mask = "(99) 90000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(215, 35);
            txtTelefone.TabIndex = 2;
            txtTelefone.MaskInputRejected += txtTelefone_MaskInputRejected;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(63, 114, 175);
            label3.Location = new Point(44, 241);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 0;
            label3.Text = "Telefone";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(249, 247, 247);
            txtNome.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(63, 114, 175);
            txtNome.Location = new Point(173, 100);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(447, 35);
            txtNome.TabIndex = 0;
            txtNome.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(63, 114, 175);
            label2.Location = new Point(81, 103);
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
            txtId.Location = new Point(173, 38);
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
            label1.Location = new Point(126, 45);
            label1.Name = "label1";
            label1.Size = new Size(41, 28);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 45, 78);
            ClientSize = new Size(685, 450);
            Controls.Add(panel1);
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
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private Button brnGravar;
        private Button btnCancelar;
    }
}