
namespace Parcial2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listArchivo = new System.Windows.Forms.ListBox();
            this.listP1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listArchivo
            // 
            this.listArchivo.FormattingEnabled = true;
            this.listArchivo.HorizontalScrollbar = true;
            this.listArchivo.Location = new System.Drawing.Point(25, 71);
            this.listArchivo.Name = "listArchivo";
            this.listArchivo.ScrollAlwaysVisible = true;
            this.listArchivo.Size = new System.Drawing.Size(396, 160);
            this.listArchivo.TabIndex = 2;
            // 
            // listP1
            // 
            this.listP1.FormattingEnabled = true;
            this.listP1.HorizontalScrollbar = true;
            this.listP1.Location = new System.Drawing.Point(25, 270);
            this.listP1.Name = "listP1";
            this.listP1.ScrollAlwaysVisible = true;
            this.listP1.Size = new System.Drawing.Size(396, 160);
            this.listP1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 603);
            this.Controls.Add(this.listP1);
            this.Controls.Add(this.listArchivo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listArchivo;
        private System.Windows.Forms.ListBox listP1;
    }
}

