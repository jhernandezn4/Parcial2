
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
            this.btnOrdenNombre = new System.Windows.Forms.Button();
            this.btnOrdenP1 = new System.Windows.Forms.Button();
            this.btnOrdenP2 = new System.Windows.Forms.Button();
            this.btnOrdenP3 = new System.Windows.Forms.Button();
            this.btnPromediosAlumnos = new System.Windows.Forms.Button();
            this.btnPromedioP1 = new System.Windows.Forms.Button();
            this.btnPromedioP3 = new System.Windows.Forms.Button();
            this.btnPromedioP2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPromediosSeccion = new System.Windows.Forms.Button();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listArchivo
            // 
            this.listArchivo.FormattingEnabled = true;
            this.listArchivo.HorizontalScrollbar = true;
            this.listArchivo.Location = new System.Drawing.Point(26, 72);
            this.listArchivo.Name = "listArchivo";
            this.listArchivo.ScrollAlwaysVisible = true;
            this.listArchivo.Size = new System.Drawing.Size(562, 121);
            this.listArchivo.TabIndex = 2;
            // 
            // listP1
            // 
            this.listP1.FormattingEnabled = true;
            this.listP1.HorizontalScrollbar = true;
            this.listP1.Location = new System.Drawing.Point(619, 29);
            this.listP1.Name = "listP1";
            this.listP1.ScrollAlwaysVisible = true;
            this.listP1.Size = new System.Drawing.Size(502, 602);
            this.listP1.TabIndex = 3;
            // 
            // btnOrdenNombre
            // 
            this.btnOrdenNombre.Location = new System.Drawing.Point(29, 246);
            this.btnOrdenNombre.Name = "btnOrdenNombre";
            this.btnOrdenNombre.Size = new System.Drawing.Size(126, 23);
            this.btnOrdenNombre.TabIndex = 4;
            this.btnOrdenNombre.Text = "Por Nombre";
            this.btnOrdenNombre.UseVisualStyleBackColor = true;
            this.btnOrdenNombre.Click += new System.EventHandler(this.btnOrdenNombre_Click);
            // 
            // btnOrdenP1
            // 
            this.btnOrdenP1.Location = new System.Drawing.Point(177, 246);
            this.btnOrdenP1.Name = "btnOrdenP1";
            this.btnOrdenP1.Size = new System.Drawing.Size(126, 23);
            this.btnOrdenP1.TabIndex = 13;
            this.btnOrdenP1.Text = "Por Parcial Uno";
            this.btnOrdenP1.UseVisualStyleBackColor = true;
            this.btnOrdenP1.Click += new System.EventHandler(this.btnOrdenP1_Click);
            // 
            // btnOrdenP2
            // 
            this.btnOrdenP2.Location = new System.Drawing.Point(315, 246);
            this.btnOrdenP2.Name = "btnOrdenP2";
            this.btnOrdenP2.Size = new System.Drawing.Size(126, 23);
            this.btnOrdenP2.TabIndex = 14;
            this.btnOrdenP2.Text = "Por Parcial Dos";
            this.btnOrdenP2.UseVisualStyleBackColor = true;
            this.btnOrdenP2.Click += new System.EventHandler(this.btnOrdenP2_Click);
            // 
            // btnOrdenP3
            // 
            this.btnOrdenP3.Location = new System.Drawing.Point(465, 246);
            this.btnOrdenP3.Name = "btnOrdenP3";
            this.btnOrdenP3.Size = new System.Drawing.Size(126, 23);
            this.btnOrdenP3.TabIndex = 15;
            this.btnOrdenP3.Text = "Por Parcial Tres";
            this.btnOrdenP3.UseVisualStyleBackColor = true;
            this.btnOrdenP3.Click += new System.EventHandler(this.btnOrdenP3_Click);
            // 
            // btnPromediosAlumnos
            // 
            this.btnPromediosAlumnos.Location = new System.Drawing.Point(29, 317);
            this.btnPromediosAlumnos.Name = "btnPromediosAlumnos";
            this.btnPromediosAlumnos.Size = new System.Drawing.Size(126, 23);
            this.btnPromediosAlumnos.TabIndex = 16;
            this.btnPromediosAlumnos.Text = "Por Alumnos";
            this.btnPromediosAlumnos.UseVisualStyleBackColor = true;
            this.btnPromediosAlumnos.Click += new System.EventHandler(this.btnPromediosAlumnos_Click);
            // 
            // btnPromedioP1
            // 
            this.btnPromedioP1.Location = new System.Drawing.Point(177, 317);
            this.btnPromedioP1.Name = "btnPromedioP1";
            this.btnPromedioP1.Size = new System.Drawing.Size(126, 23);
            this.btnPromedioP1.TabIndex = 17;
            this.btnPromedioP1.Text = "Por Parcial 1";
            this.btnPromedioP1.UseVisualStyleBackColor = true;
            this.btnPromedioP1.Click += new System.EventHandler(this.btnPromedioP1_Click);
            // 
            // btnPromedioP3
            // 
            this.btnPromedioP3.Location = new System.Drawing.Point(465, 317);
            this.btnPromedioP3.Name = "btnPromedioP3";
            this.btnPromedioP3.Size = new System.Drawing.Size(126, 23);
            this.btnPromedioP3.TabIndex = 18;
            this.btnPromedioP3.Text = "Por Parcial 3";
            this.btnPromedioP3.UseVisualStyleBackColor = true;
            this.btnPromedioP3.Click += new System.EventHandler(this.btnPromedioP3_Click);
            // 
            // btnPromedioP2
            // 
            this.btnPromedioP2.Location = new System.Drawing.Point(315, 317);
            this.btnPromedioP2.Name = "btnPromedioP2";
            this.btnPromedioP2.Size = new System.Drawing.Size(126, 23);
            this.btnPromedioP2.TabIndex = 19;
            this.btnPromedioP2.Text = "Por Parcial 2";
            this.btnPromedioP2.UseVisualStyleBackColor = true;
            this.btnPromedioP2.Click += new System.EventHandler(this.btnPromedioP2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ordenar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Promedios";
            // 
            // btnPromediosSeccion
            // 
            this.btnPromediosSeccion.Location = new System.Drawing.Point(29, 540);
            this.btnPromediosSeccion.Name = "btnPromediosSeccion";
            this.btnPromediosSeccion.Size = new System.Drawing.Size(126, 23);
            this.btnPromediosSeccion.TabIndex = 22;
            this.btnPromediosSeccion.Text = "General";
            this.btnPromediosSeccion.UseVisualStyleBackColor = true;
            this.btnPromediosSeccion.Click += new System.EventHandler(this.btnPromediosSeccion_Click);
            // 
            // txtSeccion
            // 
            this.txtSeccion.Location = new System.Drawing.Point(29, 466);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(562, 20);
            this.txtSeccion.TabIndex = 23;
            this.txtSeccion.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Procesos por Sección (Ingrese una sección)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 540);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Por Parcial 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(465, 540);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Por Parcial 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(177, 540);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Por Parcial 1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Promedios Por Sección";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(29, 376);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(559, 23);
            this.button8.TabIndex = 29;
            this.button8.Text = "Sumatoria Por Alumno";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 592);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(562, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "Clasificar Alumnos Por Sección";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 708);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSeccion);
            this.Controls.Add(this.btnPromediosSeccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPromedioP2);
            this.Controls.Add(this.btnPromedioP3);
            this.Controls.Add(this.btnPromedioP1);
            this.Controls.Add(this.btnPromediosAlumnos);
            this.Controls.Add(this.btnOrdenP3);
            this.Controls.Add(this.btnOrdenP2);
            this.Controls.Add(this.btnOrdenP1);
            this.Controls.Add(this.btnOrdenNombre);
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
        private System.Windows.Forms.Button btnOrdenNombre;
        private System.Windows.Forms.Button btnOrdenP1;
        private System.Windows.Forms.Button btnOrdenP2;
        private System.Windows.Forms.Button btnOrdenP3;
        private System.Windows.Forms.Button btnPromediosAlumnos;
        private System.Windows.Forms.Button btnPromedioP1;
        private System.Windows.Forms.Button btnPromedioP3;
        private System.Windows.Forms.Button btnPromedioP2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPromediosSeccion;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
    }
}

