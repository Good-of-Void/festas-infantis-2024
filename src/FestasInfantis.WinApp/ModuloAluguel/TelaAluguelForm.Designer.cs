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
            painelPrincipal = new Panel();
            brnGravar = new Button();
            btnCancelar = new Button();
            txtId = new TextBox();
            lblTitulo = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 226, 239);
            panel1.Controls.Add(painelPrincipal);
            panel1.Controls.Add(brnGravar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 726);
            panel1.TabIndex = 1;
            // 
            // painelPrincipal
            // 
            painelPrincipal.Location = new Point(14, 135);
            painelPrincipal.Margin = new Padding(3, 4, 3, 4);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(769, 514);
            painelPrincipal.TabIndex = 0;
            // 
            // brnGravar
            // 
            brnGravar.BackColor = Color.FromArgb(249, 247, 247);
            brnGravar.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnGravar.ForeColor = Color.FromArgb(63, 114, 175);
            brnGravar.Location = new Point(486, 656);
            brnGravar.Name = "brnGravar";
            brnGravar.Size = new Size(135, 55);
            brnGravar.TabIndex = 1;
            brnGravar.Text = "Gravar";
            brnGravar.UseVisualStyleBackColor = false;
            brnGravar.Click += brnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(249, 247, 247);
            btnCancelar.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(63, 114, 175);
            btnCancelar.Location = new Point(648, 656);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 55);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(249, 247, 247);
            txtId.Enabled = false;
            txtId.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.FromArgb(63, 114, 175);
            txtId.Location = new Point(80, 24);
            txtId.Name = "txtId";
            txtId.Size = new Size(59, 35);
            txtId.TabIndex = 9;
            txtId.Text = "0";
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(63, 114, 175);
            lblTitulo.Location = new Point(14, 94);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(769, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(63, 114, 175);
            label1.Location = new Point(35, 28);
            label1.Name = "label1";
            label1.Size = new Size(41, 28);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 45, 78);
            ClientSize = new Size(825, 753);
            Controls.Add(panel1);
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
        private Panel painelPrincipal;
        private Button brnGravar;
        private Button btnCancelar;
        private TextBox txtId;
        private Label lblTitulo;
        private Label label1;
    }
}