namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            txtId = new TextBox();
            label1 = new Label();
            lblTitulo = new Label();
            Painel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 226, 239);
            panel1.Controls.Add(Painel);
            panel1.Controls.Add(brnGravar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 501);
            panel1.TabIndex = 1;
            // 
            // brnGravar
            // 
            brnGravar.BackColor = Color.FromArgb(249, 247, 247);
            brnGravar.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnGravar.ForeColor = Color.FromArgb(63, 114, 175);
            brnGravar.Location = new Point(348, 446);
            brnGravar.Margin = new Padding(3, 2, 3, 2);
            brnGravar.Name = "brnGravar";
            brnGravar.Size = new Size(118, 41);
            brnGravar.TabIndex = 10;
            brnGravar.Text = "Gravar";
            brnGravar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(249, 247, 247);
            btnCancelar.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(63, 114, 175);
            btnCancelar.Location = new Point(488, 446);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 41);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(249, 247, 247);
            txtId.Enabled = false;
            txtId.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.FromArgb(63, 114, 175);
            txtId.Location = new Point(70, 18);
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
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(33, 23);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(63, 114, 175);
            lblTitulo.Location = new Point(31, 66);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(73, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título";
            // 
            // Painel
            // 
            Painel.Location = new Point(31, 101);
            Painel.Name = "Painel";
            Painel.Size = new Size(562, 323);
            Painel.TabIndex = 11;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 45, 78);
            ClientSize = new Size(649, 523);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAluguelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaAluguelForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Painel;
        private Button brnGravar;
        private Button btnCancelar;
        private TextBox txtId;
        private Label lblTitulo;
        private Label label1;
    }
}