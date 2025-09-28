namespace Ejercicio2
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
            listBox1 = new ListBox();
            btnListarPersonas = new Button();
            btnExportar = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(297, 244);
            listBox1.TabIndex = 0;
            // 
            // btnListarPersonas
            // 
            btnListarPersonas.Location = new Point(315, 12);
            btnListarPersonas.Name = "btnListarPersonas";
            btnListarPersonas.Size = new Size(75, 45);
            btnListarPersonas.TabIndex = 1;
            btnListarPersonas.Text = "Listar Personas";
            btnListarPersonas.UseVisualStyleBackColor = true;
            btnListarPersonas.Click += btnListarPersonas_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(315, 211);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 45);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 280);
            Controls.Add(btnExportar);
            Controls.Add(btnListarPersonas);
            Controls.Add(listBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 2";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnListarPersonas;
        private Button btnExportar;
    }
}
