namespace Practica
{
    partial class Ejercicio3
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
            this.txtParrafo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnContar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtParrafo
            // 
            this.txtParrafo.Location = new System.Drawing.Point(31, 57);
            this.txtParrafo.Multiline = true;
            this.txtParrafo.Name = "txtParrafo";
            this.txtParrafo.Size = new System.Drawing.Size(295, 157);
            this.txtParrafo.TabIndex = 0;
            this.txtParrafo.Text = "txtParrafo";
            this.txtParrafo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Párrafo:";
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(147, 246);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(179, 22);
            this.txtPalabra.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Palabra a buscar:";
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(63, 291);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(235, 39);
            this.btnContar.TabIndex = 4;
            this.btnContar.Text = "Contar repeticiones";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 361);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParrafo);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParrafo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnContar;
    }
}