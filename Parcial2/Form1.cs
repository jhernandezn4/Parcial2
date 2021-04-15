using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2.clases;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /**
             * SE ABRE EL ARCHIVO
             */
            ClsArchivo archivo = new ClsArchivo(); //La clase abre la ventana de dialogo
            this.textBox1.Text = archivo.ruta; //Se pasa la ruta del archivo al texbox del formdulario;
            string[] filas = archivo.obtenerFilas(); //SE OBTIENEN LAS FILAS DEL ARCHIVO

            /**
             * SE CARGAN LAS FILAS DEL ARCHIVO EN UN LIST BOX
             */
            foreach (string linea in filas)
            {
                this.listArchivo.Items.Add(linea);
            }

            /*
             *SE CONVIERTE EL ARREGLO DE UNA DIMENSION EN DOS DIMENSIONES 
             */
            ClsArreglo arreglo = new ClsArreglo();
            string[,] arregloDosDimensiones= arreglo.DosDimensiones(filas,6);
            string[] nombres = arreglo.OrdenarString(arregloDosDimensiones, 1);


            for(int i = 0; i < nombres.Length; i++)
            {
                this.listP1.Items.Add(nombres[i]);
            }

        }
    }
}
