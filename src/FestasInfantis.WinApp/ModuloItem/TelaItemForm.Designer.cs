namespace FestasInfantis.WinApp.ModuloItem
{
    partial class TelaItemForm
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
            label4 = new Label();
            txtDescricao = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            txtValor = new DomainUpDown();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 226, 239);
            panel1.Controls.Add(txtValor);
            panel1.Controls.Add(brnGravar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDescricao);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 267);
            panel1.TabIndex = 1;
            // 
            // brnGravar
            // 
            brnGravar.BackColor = Color.FromArgb(249, 247, 247);
            brnGravar.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnGravar.ForeColor = Color.FromArgb(63, 114, 175);
            brnGravar.Location = new Point(474, 197);
            brnGravar.Name = "brnGravar";
            brnGravar.Size = new Size(135, 55);
            brnGravar.TabIndex = 10;
            brnGravar.Text = "Gravar";
            brnGravar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(249, 247, 247);
            btnCancelar.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(63, 114, 175);
            btnCancelar.Location = new Point(629, 197);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 55);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(63, 114, 175);
            label4.Location = new Point(72, 144);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 0;
            label4.Text = "Valor";
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.FromArgb(249, 247, 247);
            txtDescricao.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.ForeColor = Color.FromArgb(63, 114, 175);
            txtDescricao.Location = new Point(158, 85);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(606, 35);
            txtDescricao.TabIndex = 0;
            txtDescricao.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(63, 114, 175);
            label2.Location = new Point(14, 88);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 0;
            label2.Text = "Descrição";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(249, 247, 247);
            txtId.Enabled = false;
            txtId.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.FromArgb(63, 114, 175);
            txtId.Location = new Point(158, 30);
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
            label1.Location = new Point(111, 33);
            label1.Name = "label1";
            label1.Size = new Size(41, 28);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtValor
            // 
            txtValor.BackColor = Color.FromArgb(249, 247, 247);
            txtValor.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValor.ForeColor = Color.FromArgb(63, 114, 175);
            txtValor.Location = new Point(158, 142);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(149, 35);
            txtValor.TabIndex = 11;
            txtValor.Text = "50";
            // 
            // TelaItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 45, 78);
            ClientSize = new Size(800, 292);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemForm";
            Text = "Tela Item";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button brnGravar;
        private Button btnCancelar;
        private Label label4;
        private TextBox txtDescricao;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private DomainUpDown txtValor;
    }
}