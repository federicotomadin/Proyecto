namespace FormEstante
{
    partial class Form1
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
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.rtxtSalida = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(283, 246);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(148, 61);
            this.btnEjecutar.TabIndex = 1;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(76, 246);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(148, 61);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // rtxtSalida
            // 
            this.rtxtSalida.Location = new System.Drawing.Point(28, 30);
            this.rtxtSalida.Name = "rtxtSalida";
            this.rtxtSalida.Size = new System.Drawing.Size(465, 183);
            this.rtxtSalida.TabIndex = 3;
            this.rtxtSalida.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 389);
            this.Controls.Add(this.rtxtSalida);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnEjecutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RichTextBox rtxtSalida;
    }
}

