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
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(63, 114, 175);
            label2.Location = new Point(40, 26);
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
            cboxNome.Location = new Point(132, 21);
            cboxNome.Name = "cboxNome";
            cboxNome.Size = new Size(121, 31);
            cboxNome.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(63, 114, 175);
            label1.Location = new Point(292, 26);
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
            cboxTema.Location = new Point(384, 21);
            cboxTema.Name = "cboxTema";
            cboxTema.Size = new Size(121, 31);
            cboxTema.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(63, 114, 175);
            label3.Location = new Point(40, 73);
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
            cboxSinal.Location = new Point(132, 68);
            cboxSinal.Name = "cboxSinal";
            cboxSinal.Size = new Size(121, 31);
            cboxSinal.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(40, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 184);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // TelaAluguelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(cboxSinal);
            Controls.Add(label3);
            Controls.Add(cboxTema);
            Controls.Add(label1);
            Controls.Add(cboxNome);
            Controls.Add(label2);
            Name = "TelaAluguelControl";
            Size = new Size(562, 323);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cboxNome;
        private Label label1;
        private ComboBox cboxTema;
        private Label label3;
        private ComboBox cboxSinal;
        private GroupBox groupBox1;
    }
}
