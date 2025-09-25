namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbResultado = new TextBox();
            btnListar = new Button();
            btnExportar = new Button();
            SuspendLayout();
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(12, 12);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(461, 426);
            tbResultado.TabIndex = 0;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(492, 12);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 47);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(492, 391);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 47);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 450);
            Controls.Add(btnExportar);
            Controls.Add(btnListar);
            Controls.Add(tbResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbResultado;
        private Button btnListar;
        private Button btnExportar;
    }
}
